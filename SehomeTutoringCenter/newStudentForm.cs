/// This class handles the logic for the New Student form.
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SehomeTutoringCenter
{
    public partial class newStudentForm : Form
    {
        public newStudentForm(studentLoginForm temp)
        {
            PopulateClassLists();
            InitializeComponent();
        }

        // Populate each combox box of the class list groupbox to contain all of the
        // subjects that are in the database.
        private void PopulateClassLists()
        {
            using (var context = new SehomeContext())
            {
                foreach (ComboBox c in ClassGroupBox.Controls)
                {
                    foreach (var v in context.Subjects)
                    {
                        c.Items.Add(v.Name);
                    }
                }
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                using (var context = new SehomeContext())
                {
                    // Grab the text of which radio button is selected
                    string CheckedButton = RadioBtnPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

                    // Create a new Student object and add it to the database
                    Student stud = new Student
                    {
                        FirstName = FirstNameTextBox.Text,
                        LastName = LastNameTextBox.Text,
                        Grade = CheckedButton
                    };
                    context.Students.Add(stud);
                    context.SaveChanges();

                    // Create registrations for this student based off of the classes picked
                    foreach(ComboBox c in ClassGroupBox.Controls)
                    {
                        if(!c.SelectedText.Equals(""))
                        {
                            var subject = from s in context.Subjects
                                          where s.Name == c.Text
                                          select s;

                            var reg = new Registration
                            {
                                Student = stud,
                                Subject = subject.First()
                            };
                            context.Registrations.Add(reg);
                        }
                    }
                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Please enter all Student Information and at least 1 class");
            }
        }

        // Returns true if the user has entered all of the necessary input, otherwise false.
        private bool ValidInput()
        {
            bool IsValid = false;
            bool RadioChecked = false;

            foreach(RadioButton c in RadioBtnPanel.Controls)
            {
                if (c.Checked)
                {
                    RadioChecked = true;
                }
            }

            if(!FirstNameTextBox.Text.Equals("") &&
                !LastNameTextBox.Text.Equals("") &&
                RadioChecked)
            {
                IsValid = true;
            }

            return IsValid;
        }
    }
}

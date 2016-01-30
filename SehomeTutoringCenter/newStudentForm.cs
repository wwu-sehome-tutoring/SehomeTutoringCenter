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
            
            InitializeComponent();
            PopulateClassLists();
        }

        // Populate each combox box of the class list groupbox to contain all of the
        // subjects that are in the database.
        private void PopulateClassLists()
        {
            using (var context = new SehomeContext())
            {
                foreach (Control c in ClassGroupBox.Controls)
                {
                    if (c is ComboBox)
                    {
                        ComboBox temp = c as ComboBox;
                        foreach (var v in context.Subjects)
                        {
                            temp.Items.Add(v.Name);
                        }
                    }
                }
            }
        }

        // This giant function creates a student object and then add in the registrations
        // and blah blah blah
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
                    foreach (Control c in ClassGroupBox.Controls)
                    {
                        if (c is ComboBox)
                        {
                            ComboBox temp = c as ComboBox;
                            // Grab the class object matching the current class name
                            var CurrentClass = context.Subjects
                                .Where(s => s.Name == c.Text)
                                .FirstOrDefault();

                            // Create the registration
                            var Reg = new Registration
                            {
                                Student = stud,
                                Subject = CurrentClass
                            };
                            context.Registrations.Add(Reg);
                            context.SaveChanges();
                        }
                    }

                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter all Student Information and select your classes");
            }
        }

        // Returns true if the user has entered all of the necessary input, otherwise false.
        private bool ValidInput()
        {
            bool IsValid = false;
            bool RadioChecked = false;
            bool SelectedAllClasses = true;

            // Ensure the user has selected a grade
            foreach(RadioButton c in RadioBtnPanel.Controls)
            {
                if (c.Checked)
                {
                    RadioChecked = true;
                }
            }
            // Ensure the user has selected all classes
            foreach(Control c in ClassGroupBox.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox temp = c as ComboBox;
                    if(temp.Text == "")
                    {
                        SelectedAllClasses = false;
                    }
                }
            }

            if(!FirstNameTextBox.Text.Equals("") &&
                !LastNameTextBox.Text.Equals("") &&
                RadioChecked && SelectedAllClasses)
            {
                IsValid = true;
            }

            return IsValid;
        }
    }
}

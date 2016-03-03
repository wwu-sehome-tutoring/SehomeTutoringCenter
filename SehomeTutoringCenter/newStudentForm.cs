/// This class handles the logic for the New Student form.
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SehomeTutoringCenter
{
    public partial class newStudentForm : Form
    {
        private SehomeContext _context = new SehomeContext();
        private MainForm temp1;

        public newStudentForm(MainForm temp)
        {
            InitializeComponent();
            PopulateClassLists();
            temp1 = temp;
        }

        // Populate each combox box of the class list groupbox to contain all of the
        // subjects that are in the database.
        private void PopulateClassLists()
        {
                foreach (Control c in ClassGroupBox.Controls)
                {
                    if (c is ComboBox)
                    {
                        ComboBox temp = c as ComboBox;
                        foreach (var v in _context.Subjects)
                        {
                            temp.Items.Add(v.Name + "-" + v.TeacherName);
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
                // Grab the text of which radio button is selected
                string CheckedButton = RadioBtnPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

                // Create a new Student object and add it to the database
                Student stud = new Student
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    Grade = CheckedButton
                };
                _context.Students.Add(stud);
                _context.SaveChanges();

                // Create registrations for this student based off of the classes picked
                foreach (Control c in ClassGroupBox.Controls)
                {
                    if (c is ComboBox)
                    {
                        ComboBox temp = c as ComboBox;
                        string ClassName = temp.Text.Split('-')[0];
                        if (ClassName != "") {
                            // Grab the class object matching the current class name
                            var CurrentClass = _context.Subjects
                                .Where(s => s.Name == ClassName)
                                .FirstOrDefault();

                            // Create the registration
                            var Reg = new Registration
                            {
                                Student = stud,
                                Subject = CurrentClass
                            };
                            _context.Registrations.Add(Reg);
                            _context.SaveChanges();
                        }
                    }
                }

                temp1.studentNames.Items.Add(stud.FirstName + " " + stud.LastName);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter all Student Information and classes that are all unique");
            }
        }

        // Returns true if the user has entered all of the necessary input, otherwise false.
        private bool ValidInput()
        {
            bool IsValid = false;
            bool RadioChecked = false;
            bool SelectedAClass = false;
            bool AllUnique = true;
            HashSet<string> set = new HashSet<string>();
;
            // Ensure the user has selected a grade
            foreach(RadioButton c in RadioBtnPanel.Controls)
            {
                if (c.Checked)
                {
                    RadioChecked = true;
                }
            }
            // Ensure the user has selected at least 1 class and that they are all unique
            foreach(Control c in ClassGroupBox.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox temp = c as ComboBox;
                    if (set.Contains(temp.Text))
                    {
                        AllUnique = false;
                    } else
                    {
                        if (temp.Text != "")
                        {
                            SelectedAClass = true;
                            set.Add(temp.Text);
                        }
                    }
                }
            }

            // Ensure that everything has been properly entered
            if(!FirstNameTextBox.Text.Equals("") &&
                !LastNameTextBox.Text.Equals("") &&
                RadioChecked && SelectedAClass && AllUnique)
            {
                IsValid = true;
            }

            return IsValid;
        }
    }
}

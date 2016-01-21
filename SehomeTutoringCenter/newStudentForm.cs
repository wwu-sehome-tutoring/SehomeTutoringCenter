﻿/// This class handles the logic for the New Student form.
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
        }

        // The Add Student buttonc an only be clicked if the appropriate forms are filled out.
        // This includes all of the student information and at least one class.
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            using (SehomeContext context = new SehomeContext())
            {
                if (ValidInput())
                {
                    string CheckedButton = RadioBtnPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

                    // Using the student information, add the student to the database
                    Student Stud = new Student
                    {
                        FirstName = FirstNameTextBox.Text,
                        LastName = LastNameTextBox.Text,
                        Grade = CheckedButton
                    };
                    context.Students.Add(Stud);

                    // Using the class list information, add classes and teacher names to the database
                    foreach (Control c in ClassGroupBox.Controls)
                    {
                        if (c is Panel)
                        {
                            var names = c.Controls.Cast<Control>();
                            if (names.ElementAt(0).Text.Length > 0 && names.ElementAt(1).Text.Length > 0)
                            {
                                Subject sub = new Subject
                                {
                                    Name = names.ElementAt(0).Text,
                                    TeacherName = names.ElementAt(1).Text
                                };
                                context.Subjects.Add(sub);
                            }
                        }
                    }
                    context.SaveChanges();

                    foreach (var v in context.Students)
                    {
                        MessageBox.Show(v.Grade);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter all Student Information and at least 1 class/teacher pair.");
                }
            }
        }

        private bool ValidInput()
        {
            bool Valid = false;

            if(!FirstNameTextBox.Text.Equals("") && !LastNameTextBox.Text.Equals(""))
            {
                Valid = true;
            }

            return Valid;
        }

    }
}

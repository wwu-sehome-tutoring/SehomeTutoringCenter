using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace SehomeTutoringCenter
{
    public partial class studentLoginForm : Form
    {
        private SehomeContext _context = new SehomeContext();

        // Some global variables - should probably do it better
        string SelectedStudentName;
        string SelectedNewClassName;
        bool NameSelected = false;

        public studentLoginForm()
        {
            InitializeComponent();
            PopulateSomeData();
        }

        // At program start up, fill in the ListBox of the student names that
        // are already in the database, if there are any.  And fill in the classes
        // to the new class combo box
        private void PopulateSomeData()
        {
            foreach (var v in _context.Students)
            {
                var FullName = v.FirstName + " " + v.LastName;
                studentNames.Items.Add(FullName);
            }

            foreach (var s in _context.Subjects)
            {
                NewClassComboBox.Items.Add(s.Name);
            }
        }

        // Event handling for the student name select on the login page
        private void studentNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedStudentName = (string)studentNames.SelectedItem;
            NameSelected = true;
        }

        // Event handling for the Check In button
        private void checkIn_Click(object sender, EventArgs e)
        {
            if (NameSelected)
            {
                // The chunk of code below will make the class select items pop up
                // and also show the cancel button
                CourseSelectBox.Location = new Point(734, 429);
                CourseSelectBox.Visible = true;

                CheckInVisitButton.Location = new Point(734, 761);
                CheckInVisitButton.Width = 406;
                CheckInVisitButton.Text = "Check In";

                CancelButton.Location = new Point(1146, 761);
                CancelButton.Visible = true;

                NewClassButton.Visible = true;
                NewClassComboBox.Visible = true;

                studentNames.Enabled = false;

                // Now populate the check in area with all of the classes and teacher 
                // names of the selected students

                // grab the student object
                string[] names = SelectedStudentName.Split(' ');
                string TempFirst = names[0];
                string TempLast = names[1];
                Console.WriteLine(names[0] + " " + names[1]);

                var StudentQuery = from s in _context.Students
                                    where s.FirstName == TempFirst && s.LastName == TempLast
                                    select s;

                var student = StudentQuery.FirstOrDefault();

                // Grab the names of the selected students classes
                ArrayList classes = new ArrayList();
                foreach (var r in _context.Subjects)
                {
                    classes.Add(r.Name);
                }

                // Update the radio buttons to show class names
                int i = 0;
                foreach (Control c in CourseSelectBox.Controls)
                {
                    if (c is RadioButton)
                    {
                        c.Text = classes[i].ToString();
                        c.Visible = true;
                        i++;
                    }
                }
                // Change the welcome text to match the student name
                WelcomeLabel.Text = String.Format("Welcome {0}, what are you going to study today?", student.FirstName);

            } else
            {
                MessageBox.Show("Please select a name from the list of students");
            }
        }

        // When a new class is selected, set the global variable to be its text value
        private void NewClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedNewClassName = (string)NewClassComboBox.SelectedItem;
            Console.WriteLine(SelectedNewClassName);
        }

        // Create a new Registration for the currently selected student
        private void NewClassButton_Click(object sender, EventArgs e)
        {

            // grab the student object
            string[] names = SelectedStudentName.Split(' ');
            string TempFirst = names[0];
            string TempLast = names[1];

            var StudentQuery = from s in _context.Students
                                where s.FirstName == TempFirst && s.LastName == TempLast
                                select s;

            var student = StudentQuery.FirstOrDefault();

            // grab the subject object
            var CurrentClass = _context.Subjects
                                .Where(s => s.Name == SelectedNewClassName)
                                .FirstOrDefault();

            // Check to see if the user is already registered for this class
            bool IsRegistered = false;
            foreach(var r in _context.Registrations)
            {
                if(r.StudentId == student.Id && r.SubjectId == CurrentClass.Id)
                {
                    IsRegistered = true;
                    MessageBox.Show("You are already registered for this class...");
                }
            }

            // Create the registration
            if (!IsRegistered)
            {
                var Reg = new Registration
                {
                    Student = student,
                    Subject = CurrentClass
                };
                _context.Registrations.Add(Reg);
                _context.SaveChanges();
            }
        }

        // Make sure that the user has selected a class and then create a visit object
        private void CheckInVisitButton_Click(object sender, EventArgs e)
        {
            // Have they selected a class?
            bool HasSelected = false;
            string SelectedClassName = null;
            foreach (Control c in CourseSelectBox.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton r = c as RadioButton;
                    if (r.Checked)
                    {
                        SelectedClassName = r.Text;
                        HasSelected = true;
                    }
                }
            }

            // Create the visit object if a class is selected
            if (HasSelected)
            {
                var SelectedClass = _context.Subjects
                    .Where(s => s.Name == SelectedClassName)
                    .FirstOrDefault();

                // Grab the student object matching the selected name
                string[] names = SelectedStudentName.Split(' ');
                string TempFirst = names[0];
                string TempLast = names[1];
                var StudentQuery = from s in _context.Students
                                    where s.FirstName == TempFirst && s.LastName == TempLast
                                    select s;

                var student = StudentQuery.First();
                string FullName = student.FirstName + " " + student.LastName;

                // Create the visit object
                var vis = new Visit
                {
                    TimeIn = DateTime.Now,
                    Student = student,
                    Subject = SelectedClass
                };

                _context.Visits.Add(vis);
                _context.SaveChanges();
                resetPositions();

                // Finally, update the list of student names in the listbox to indiciate that
                // the student has logged in for this session.
                studentNames.Items.Clear();
                foreach (var v in _context.Students)
                {
                    var CurrName = v.FirstName + " " + v.LastName;

                    if (CurrName.Equals(FullName))
                    {
                        studentNames.Items.Add(CurrName + " ✔");
                    } else
                    {
                        studentNames.Items.Add(CurrName);
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select a class.");
            }
        }

        // Event handling for the Check Out button
        private void checkOut_Click(object sender, EventArgs e)
        {
            if (NameSelected)
            {
                Console.WriteLine("clicked checkout");
                // Grab the selected student and see if they are currently logged in
                string[] names = SelectedStudentName.Split(' ');
                string TempFirst = names[0];
                string TempLast = names[1];
                var StudentQuery = from s in _context.Students
                                    where s.FirstName == TempFirst && s.LastName == TempLast
                                    select s;

                var student = StudentQuery.First();

                string CurrentDate = DateTime.Now.ToString().Split(' ')[0];

                // Find each visit for the current day
                foreach (var v in _context.Visits)
                {
                    Console.WriteLine("visit check");
                    string date = v.TimeIn.ToString().Split(' ')[0];
                    if (CurrentDate.Equals(date))
                    {
                        try {
                            // See if the student is logged in for the day
                            if (v.Student.FirstName.Equals(TempFirst) && v.Student.LastName.Equals(TempLast))
                            {
                                v.TimeOut = DateTime.Now;
                                Console.WriteLine("checked out");
                            }
                        } catch(NullReferenceException)
                        {
                            MessageBox.Show("Visits have no student or subjects in them");
                            break;
                        }
                    }

                }
                _context.SaveChanges();
            } else
            {
                MessageBox.Show("Please select a name from the list of students");
            }
        }

        // Event handling for when a course gets selected from the login page
        private void courseListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckInVisitButton.Enabled = true;
        }

        // Event handling for student tab button
        private void studentsTab_Click(object sender, EventArgs e)
        {
            studentStats studentStats = new studentStats();
            studentStats.Show();
        }

        // Event handling for the center tab button
        private void centerTab_Click(object sender, EventArgs e)
        {
            CenterStatsForm center = new CenterStatsForm();
            center.Show();
        }

        // Event handling for the admin tab button
        private void adminTab_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            admin.Show();
        }

        // Event handling for the new student button
        private void newStudentBtn_Click(object sender, EventArgs e)
        {
            newStudentForm newStudent = new newStudentForm(this);
            newStudent.ShowDialog();

            // Re-populate the listbox with the new students name
            studentNames.Items.Clear();
            PopulateSomeData();

        }

        // Event handling for the cancel button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            resetPositions();
        }

        // Function to reset the positions of some of the UI elements
        private void resetPositions()
        {
            CheckInVisitButton.Location = new Point(734, 432);
            CheckInVisitButton.Text = "Students Subjects";
            CheckInVisitButton.Width = 526;

            CourseSelectBox.Visible = false;

            CancelButton.Visible = false;

            studentNames.Enabled = true;
            studentNames.ClearSelected();

            NewClassButton.Visible = true;
            NewClassComboBox.Visible = true;

            NameSelected = false;

            foreach (Control c in CourseSelectBox.Controls)
            {
                if (c is RadioButton)
                {
                    c.Visible = false;
                }
            }
        }
    }
}

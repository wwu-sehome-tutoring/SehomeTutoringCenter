using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace SehomeTutoringCenter
{
    public partial class studentLoginForm : Form
    {
        // Some global variables - should probably do it better
        string SelectedStudentName;
        bool NameSelected = false;

        public studentLoginForm()
        {
            InitializeComponent();
            PopulateStudentNames();
        }

        // At program start up, fill in the ListBox of the student names that
        // are already in the database, if there are any.
        private void PopulateStudentNames()
        {
            var context = new SehomeContext();

            foreach (var v in context.Students)
            {
                var FullName = v.FirstName + " " + v.LastName;
                studentNames.Items.Add(FullName);
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

                CheckInVisitButton.Location = new Point(734, 731);
                CheckInVisitButton.Width = 406;
                CheckInVisitButton.Text = "Check In";

                CancelButton.Location = new Point(1146, 731);
                CancelButton.Visible = true;

                studentNames.Enabled = false;

                // Now populate the check in area with all of the classes and teacher 
                // names of the selected students
                using (var context = new SehomeContext())
                {
                    // grab the student object
                    string[] names = SelectedStudentName.Split(' ');
                    string TempFirst = names[0];
                    string TempLast = names[1];
                    Console.WriteLine(names[0] + " " + names[1]);

                    var StudentQuery = from s in context.Students
                                       where s.FirstName == TempFirst && s.LastName == TempLast
                                       select s;

                    var student = StudentQuery.FirstOrDefault();
                    Console.WriteLine("Student id: {0}", student.Id);

                    // Grab the names of the selected students classes
                    ArrayList classes = new ArrayList();
                    var classesTemp = from s in context.Registrations
                                      where s.StudentId == student.Id
                                      select s;

                    foreach (var r in context.Subjects)
                    {
                        classes.Add(r.Name);
                    }

                    // Update the radio buttons
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
                }
            } else
            {
                MessageBox.Show("Please select a name from the list of students");
            }
        }

        // Make sure that the user has selected a class and then create a visit object
        private void CheckInVisitButton_Click(object sender, EventArgs e)
        {
            using (var context = new SehomeContext())
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
                    var SelectedClass = context.Subjects
                        .Where(s => s.Name == SelectedClassName)
                        .FirstOrDefault();

                    // Grab the student object matching the selected name
                    string[] names = SelectedStudentName.Split(' ');
                    string TempFirst = names[0];
                    string TempLast = names[1];
                    var StudentQuery = from s in context.Students
                                       where s.FirstName == TempFirst && s.LastName == TempLast
                                       select s;

                    var student = StudentQuery.First();

                    var vis = new Visit
                    {
                        TimeIn = DateTime.Now,
                        Student = student,
                        Subject = SelectedClass
                    };

                    context.Visits.Add(vis);
                    context.SaveChanges();
                    resetPositions();
                    Console.WriteLine(context.Visits.Count().ToString());
                }
                else
                {
                    MessageBox.Show("You must select a class.");
                }
            }
        }

        // Event handling for the Check Out button
        private void checkOut_Click(object sender, EventArgs e)
        {
            if (NameSelected)
            {
                Console.WriteLine("clicked checkout");
                using (var context = new SehomeContext())
                {
                    // Grab the selected student and see if they are currently logged in
                    string[] names = SelectedStudentName.Split(' ');
                    string TempFirst = names[0];
                    string TempLast = names[1];
                    var StudentQuery = from s in context.Students
                                       where s.FirstName == TempFirst && s.LastName == TempLast
                                       select s;

                    var student = StudentQuery.First();

                    string CurrentDate = DateTime.Now.ToString().Split(' ')[0];
                    // Find a visit matching the current student .... redo this ....
                    foreach (var v in context.Visits)
                    {
                        Console.WriteLine("visit check");
                        string date = v.TimeIn.ToString().Split(' ')[0];
                        if (CurrentDate.Equals(date))
                        {
                            try {
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
                    context.SaveChanges();
                }
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

        }

        // Event handling for the new student button
        private void newStudentBtn_Click(object sender, EventArgs e)
        {
            newStudentForm newStudent = new newStudentForm(this);

            newStudent.ShowDialog();
            // Re-populate the listbox with the new students name
            studentNames.Items.Clear();
            PopulateStudentNames();

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

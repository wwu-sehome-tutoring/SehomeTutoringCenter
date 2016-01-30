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
        Student SelectedStudentObject;

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
        // Event handling for the Check In button
        private void checkIn_Click(object sender, EventArgs e)
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
                // grab the names of each class for that student
                string[] names = SelectedStudentName.Split(' ');
                // Get all students with the first name "JJ".
                var StudentQuery = from s in context.Students
                                      where s.FirstName.Equals("JJ")
                                      select s;


                // Get the first student whose name begins with "JJ".
                var student = StudentQuery.First();

                SelectedStudentObject = student;
                MessageBox.Show(student.FirstName + " " + student.LastName + " " + student.Grade + context.Registrations.Count().ToString());
               
                // Grab the names of the selected students classes
                ArrayList classes = new ArrayList();
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

        }
        // Event handling for the Check Out button
        private void checkOut_Click(object sender, EventArgs e)
        {
            using (var context = new SehomeContext())
            {
                // Grab the selected student and see if they are currently logged in
                string[] names = SelectedStudentName.Split(' ');
                var StudentQuery = from s in context.Students
                                   where s.FirstName == names[0] && s.LastName == names[1]
                                   select s;

                var student = StudentQuery.First();
                SelectedStudentObject = student;

                string CurrentDate = DateTime.Now.ToString();
                // Find a visit matching the current student .... redo this ....
                foreach(var v in context.Visits)
                {
                    string date = v.TimeIn.ToString().Split(' ')[0];
                    if(CurrentDate.Equals(date))
                    {
                        if(v.Student.FirstName.Equals(names[0]))
                        {
                            v.TimeOut = DateTime.Now;
                        }
                    }

                }
            }
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
        // Event handling for the student name select on the login page
        private void studentNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedStudentName = (string)studentNames.SelectedItem;

            checkIn.Enabled = true;
            checkOut.Enabled = true;
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
        // Event handling for when a course gets selected from the login page
        private void courseListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckInVisitButton.Enabled = true;
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
            CheckInVisitButton.Enabled = true;

            CourseSelectBox.Visible = false;

            CancelButton.Visible = false;

            studentNames.Enabled = true;

            foreach (Control c in CourseSelectBox.Controls)
            {
                if (c is RadioButton)
                {
                    c.Visible = false;
                }
            }
        }
        // Make sure that the user has selected a class and then create a visit object
        private void CheckInVisitButton_Click(object sender, EventArgs e)
        {
            using (var context = new SehomeContext()) {
                // Have they selected a class?
                bool HasSelected = false;
                string SelectedClassName = null;
                foreach(Control c in CourseSelectBox.Controls)
                {
                    if(c is RadioButton)
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

                    var vis = new Visit
                    {
                        TimeIn = DateTime.Now,
                        Student = SelectedStudentObject,
                        Subject = SelectedClass
                    };

                    context.Visits.Add(vis);
                    context.SaveChanges();
                    resetPositions();
                    Console.WriteLine(context.Visits.Count().ToString());
                } else
                {
                    MessageBox.Show("You must select a class.");
                }
            }
        }
    }
}

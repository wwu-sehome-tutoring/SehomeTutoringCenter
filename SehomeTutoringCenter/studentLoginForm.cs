using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace SehomeTutoringCenter
{
    public partial class studentLoginForm : Form
    {
        string SelectedStudentName;

        public studentLoginForm()
        {
            PopulateStudentNames();
            InitializeComponent();
        }

        // At program start up, fill in the ListBox of the student names that
        // are already in the database, if there are any.
        private void PopulateStudentNames()
        {
            var context = new SehomeContext();

            foreach(var v in context.Students)
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
            CheckInVisitButton.Enabled = false;

            CancelButton.Location = new Point(1146, 731);
            CancelButton.Visible = true;

            studentNames.Enabled = false;

            // Now populate the check in area with all of the classes and teacher 
            // names of the selected students
            using (var context = new SehomeContext())
            {
                // Grab the names of each class for that student
                string[] names = SelectedStudentName.Split(' ');
                var student = from s in context.Students
                              where s.FirstName == names[0]
                              where s.LastName == names[1]
                              select s;

                ArrayList classes = new ArrayList();
                foreach (var r in student.Registrations)
                {
                    classes.Add(r.Subject.Name);
                }

                // Update the radio buttons
                int i = 0;
                foreach (RadioButton c in CourseSelectBox.Controls)
                {
                    c.Text = classes[i].ToString();
                    i++;
                }

            }
            
        }
        // Event handling for the Check Out button
        private void checkOut_Click(object sender, EventArgs e)
        {

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
            SelectedStudentName = this.Text;
           
            checkIn.Enabled = true;
            checkOut.Enabled = true;
        }
        // Event handling for the new student button
        private void newStudentBtn_Click(object sender, EventArgs e)
        {
            newStudentForm newStudent = new newStudentForm(this);

            newStudent.Show();
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
        }

        private void CheckInVisitButton_Click(object sender, EventArgs e)
        {

        }
    }
}

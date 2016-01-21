using System;
using System.Drawing;
using System.Windows.Forms;

namespace SehomeTutoringCenter
{
    public partial class studentLoginForm : Form
    {
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

            coursesDropDown.Location = new Point(734, 731);
            coursesDropDown.Width = 406;
            coursesDropDown.Text = "Check In";
            coursesDropDown.Enabled = false;

            CancelButton.Location = new Point(1146, 731);
            CancelButton.Visible = true;

            studentNames.Enabled = false;

            // Now populate the check in area with all of the classes and teacher 
            // names of the selected students
            var context = new SehomeContext();
            
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
            checkIn.Enabled = true;
            // Have to have the student class working for this
            // if(studentNameWhatever.loggedIn = TRUE...
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
            coursesDropDown.Enabled = true;
        }
        // Event handling for the cancel button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            resetPositions();
        }

        // Function to reset the positions of some of the UI elements
        private void resetPositions()
        {
            coursesDropDown.Location = new Point(734, 432);
            coursesDropDown.Text = "Students Subjects";
            coursesDropDown.Width = 526;
            coursesDropDown.Enabled = true;

            CourseSelectBox.Visible = false;

            CancelButton.Visible = false;
            
            studentNames.Enabled = true;      
        }
    }
}

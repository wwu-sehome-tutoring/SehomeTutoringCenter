using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehomeTutoringCenter
{
    public partial class studentLoginForm : Form
    {
        public studentLoginForm()
        {
            InitializeComponent();

        }

        // Event handling for the main window.
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Event handling for the Check In button
        private void checkIn_Click(object sender, EventArgs e)
        {
            courseSelectBox.Location = new Point(468, 377);
            coursesDropDown.Location = new Point(468, 503);
            courseSelectBox.Visible = true;
            coursesDropDown.Text = "Check In";
            coursesDropDown.Enabled = false;
            studentNames.Enabled = false;
        }
        // Event handling for the Check Out button
        private void checkOut_Click(object sender, EventArgs e)
        {

        }
        // Event handling for the courses drop down button
        private void coursesDropDown_Click(object sender, EventArgs e)
        {
            String s = coursesDropDown.Text.ToString();

            if (s.Equals("Check In"))
            {
                coursesDropDown.Location = new Point(469, 387);
                courseSelectBox.Visible = false;
                studentNames.ClearSelected();
                studentNames.Enabled = true;
            }
            
        }
        // Event handling for student tab button
        private void studentsTab_Click(object sender, EventArgs e)
        {

        }
        // Event handling for the center tab button
        private void centerTab_Click(object sender, EventArgs e)
        {

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
    }
}

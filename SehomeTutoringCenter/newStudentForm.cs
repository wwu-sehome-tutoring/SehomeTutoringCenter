/// This class handles the logic for the New Student form.
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
    public partial class newStudentForm : Form
    {
        // Create a temporary which will receive the new student data
        studentLoginForm temp;
        public newStudentForm(studentLoginForm temp)
        {
            InitializeComponent();
            this.temp = temp;
        }

        // The Add Student buttonc an only be clicked if the appropriate forms are filled out.
        // This includes all of the student information and at least one class.
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            if(this.Enabled)
            {
                string fullName = firstNameTextBox.Text + lastNameTextBox.Text;
                
                temp.studentNames.Items.Add(fullName);

                this.Close();
            }

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            addStudentButton.Enabled = true;
        }
    }
}

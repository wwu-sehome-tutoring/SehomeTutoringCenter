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
        studentLoginForm temp;
        public newStudentForm(studentLoginForm temp)
        {
            InitializeComponent();
            this.temp = temp;
        }

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

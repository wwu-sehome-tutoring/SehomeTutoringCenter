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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addSubject_Click()
        {

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {

        }

        // Event handling for clicking on the add/remove class button
        private void EditClassButton_Click(object sender, EventArgs e)
        {
            EditClassForm f = new EditClassForm();
            f.ShowDialog();
        }

        // Event handling for clicking on the edit student button
        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            EditStudentForm f = new EditStudentForm();
            f.ShowDialog();
        }

        private void NewSemesterButton_Click(object sender, EventArgs e)
        {

        }

        private void loginTab_Click(object sender, EventArgs e)
        {

        }

        private void studentTab_Click(object sender, EventArgs e)
        {

        }

        private void centerTab_Click(object sender, EventArgs e)
        {

        }
    }
}

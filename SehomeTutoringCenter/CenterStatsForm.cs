using System;
using System.Collections;
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
    public partial class CenterStatsForm : Form
    {
        public CenterStatsForm()
        {
            InitializeComponent();
            PopulateSubjectNames();
        }

        private void PopulateSubjectNames()
        {
            using (var context = new SehomeContext())
            {
                foreach (var s in context.Subjects)
                {
                    subjectComboBox.Items.Add(s.Name);
                }
            }
        }

        private void loginTab_Click(object sender, EventArgs e)
        {

        }

        private void studentTab_Click(object sender, EventArgs e)
        {

        }

        private void adminTab_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CenterStatsForm_Load(object sender, EventArgs e)
        {

        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        // Select a random student that has a current visit object in the system
        static Random rnd = new Random();
        private void PrizeButton_Click(object sender, EventArgs e)
        {
            // Grab the list of student name
            using (var context = new SehomeContext())
            {
                ArrayList names = new ArrayList();
                foreach (var s in context.Students)
                {
                    string FullName = s.FirstName + " " + s.LastName;
                    names.Add(FullName);
                }
                // Now select a random name from the list
                int r = rnd.Next(names.Count);
                RandomNameTextbox.Text = (string)names[r];
            }
        }
    }
}

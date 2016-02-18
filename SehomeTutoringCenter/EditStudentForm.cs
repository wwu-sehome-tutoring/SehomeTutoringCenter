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
    public partial class EditStudentForm : Form
    {
        private SehomeContext _context = new SehomeContext();
        private DBHelper _dbh = new DBHelper();

        public EditStudentForm()
        {
            InitializeComponent();
            PopulateLists();
        }

        // Populate each combox box of the class list groupbox to contain all of the
        // subjects that are in the database.  Also adds in all students names.
        private void PopulateLists()
        {
            foreach(var s in _context.Students)
            {
                StudentList.Items.Add(s.FirstName + " " + s.LastName);
            }

            foreach (Control c in ClassGroupBox.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox temp = c as ComboBox;
                    foreach (var v in _context.Subjects)
                    {
                        temp.Items.Add(v.Name);
                    }
                }
            }
        }

        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {

        }

        // When a name gets selected from the list, fill in the various fields of
        // the form with the information of that selected student.
        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // There's gotta be a better way to do this....
            string SelectedName = (string)StudentList.SelectedItem;
            string[] names = SelectedName.Split(' ');
            string TempFirst = names[0];
            string TempLast = names[1];

            var StudentQuery = from s in _context.Students
                               where s.FirstName == TempFirst && s.LastName == TempLast
                               select s;

            var student = StudentQuery.FirstOrDefault();

            // Now that we have the student object matching the selected name, do stuff
            FirstNameTextBox.Text = student.FirstName;
            LastNameTextBox.Text = student.LastName;

            foreach (Control c in RadioBtnPanel.Controls)
            {
                if (c.Text.Contains(student.Grade))
                {
                    c.Select();
                }
            }

            var cs = from controls in ClassGroupBox.Controls.OfType<ComboBox>().ToList()
                    select controls;

            int i = 0;
            foreach (var s in _dbh.SubjectsFromStudent(_context, student))
            {
                cs.ElementAt(i).Text = s.Name;
                i++;
            }
        }
    }
}

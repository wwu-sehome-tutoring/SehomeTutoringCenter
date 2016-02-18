using System;
using System.Windows.Forms;

namespace SehomeTutoringCenter
{
    public partial class EditClassForm : Form
    {
        private SehomeContext _context = new SehomeContext();

        public EditClassForm()
        {
            InitializeComponent();
            PopulateClasses();
        }
         
        // Fill the ListBox of class names
        private void PopulateClasses()
        {
            foreach(var v in _context.Subjects)
            {
                ClassList.Items.Add(v.Name);
            }
        }

        // Create a new class from the given data from the form
        private void AddClassButton_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                var subject = new Subject
                {
                    Name = ClassNameTB.Text,
                    TeacherName = TeacherNameTB.Text
                };
                _context.Subjects.Add(subject);
                _context.SaveChanges();
            }
        }

        // Helper function to make sure that the input for the add class is valid
        private bool IsValid()
        {
            bool valid = true;

            if(ClassNameTB.Text.Equals("") || TeacherNameTB.Text.Equals(""))
            {
                valid = false;
                MessageBox.Show("Please enter a class and teacher name");
            }

            foreach(var v in _context.Subjects)
            {
                if(ClassNameTB.Text.Equals(v.Name) && TeacherNameTB.Text.Equals(v.TeacherName))
                {
                    valid = false;
                    MessageBox.Show("Class already exists in the database");
                }
            }

            return valid;
        }

        // When a class gets selected, remove it from various places in the database
        private void RemoveClassButton_Click(object sender, EventArgs e)
        {

        }
    }
}

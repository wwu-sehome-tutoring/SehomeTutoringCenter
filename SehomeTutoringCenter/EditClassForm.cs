using System;
using System.Linq;
using System.Windows.Forms;

namespace SehomeTutoringCenter
{
    public partial class EditClassForm : Form
    {
        private SehomeContext _context = new SehomeContext();
        private DBHelper _dbh = new DBHelper();

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
                ClassList.Items.Add(v.Name + "-" + v.TeacherName);
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

                MessageBox.Show("The new class has been added.");
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
            string ClassName = ClassList.SelectedItem.ToString().Split('-')[0];

            var CurrentClass = _context.Subjects
                                .Where(s => s.Name == ClassName)
                                .FirstOrDefault();

            // Remove all registrations matching the selected class
            foreach (var r in _context.Registrations)
            {
                if (r.SubjectId == CurrentClass.Id)
                {
                    _context.Registrations.Remove(r);
                    Console.WriteLine("removed registration for " + ClassName);
                }
            }

            // Remove all visits that have a subject matching the selected class
            foreach(var v in _context.Visits)
            {
                if(v.SubjectId == CurrentClass.Id)
                {
                    _context.Visits.Remove(v);
                    Console.WriteLine("removed visits for " + ClassName);
                }
            }

            // Remove the class for the subject table
            foreach (var s in _context.Subjects)
            {
                if(s.Name.Equals(ClassName))
                {
                    _context.Subjects.Remove(s);
                    Console.WriteLine("removed " + ClassName);
                }
            }

            _context.SaveChanges();
            MessageBox.Show("The class has been removed.");
            
        }
    }
}

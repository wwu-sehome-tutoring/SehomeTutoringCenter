using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SehomeTutoringCenter
{
    public partial class adminForm : Form
    {
        private SehomeContext _context = new SehomeContext();
        private DBHelper _dbh = new DBHelper();

        public adminForm()
        {
            InitializeComponent();
            PopulateGridView();

            // Grab the total number of students in the system
            int TotalStudents = _context.Students.Count();
            TotalStudentsBox.Text = TotalStudents.ToString();
        }

        private void PopulateGridView()
        {
            string current = DateTime.Now.ToString().Split(' ')[0];
            ArrayList names = new ArrayList();

            foreach (var v in _context.Visits)
            {
                if (v.TimeIn.ToString().Split(' ')[0].Equals(current))
                {
                    var s = _dbh.StudentFromVisit(_context, v);
                    dataGridView1.Rows.Add(s.FirstName + " " + s.LastName,
                                            _dbh.SubjectFromVisit(_context, v).Name,
                                            v.TimeIn, v.TimeOut, 0);

                }
            }

        }

        // This function will open up a dialogue to import a file
        private void ImportButton_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            StreamReader readStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c://";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            readStream = new StreamReader(myStream);
                            System.Diagnostics.Debug.WriteLine(readStream.Peek());
                            readStreamToDB(readStream);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. Error: " + ex.Message);
                }
            }
        }

        //Read the stream selected in the FileDialog and add to database
        private void readStreamToDB(StreamReader readStream)
        {
            while (!readStream.EndOfStream)
            {
                var line = readStream.ReadLine();
                var tokens = line.Split(',');

                var Sub = new Subject
                {
                    Name = tokens[0],
                    TeacherName = tokens[1]
                };
                //http://stackoverflow.com/questions/9287454/check-the-existence-of-a-record-before-inserting-a-new-record
                var existingSubject = _context.Subjects.Where(s => s.Name == Sub.Name).FirstOrDefault();
                //var existingSubject = _context.Subjects.Where(s => s.TeacherName == Sub.TeacherName && s.Name == Sub.Name);
                if (existingSubject == null)//_context.Subjects.Select(s => s.Name).Where(Name => Name == Sub.Name).Take(1) == null)
                {
                    _context.Subjects.Add(Sub);
                }
            }
            _context.SaveChanges();
            MessageBox.Show("Class and Teacher CSV uploaded.");
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

        // For a new semester, just move the current database file to another location
        // and then delete it from the current location
        private void NewSemesterButton_Click(object sender, EventArgs e)
        {
            // Grab the current database
            string CWD = Directory.GetCurrentDirectory();
            string SourcePath = CWD + "\\SehomeTutoringCenter.sqlite";
            Console.WriteLine(SourcePath);

            string DestDir = CWD + "\\DatabaseBackups";
            string DestPath = DestDir + "\\SehomeTutoringCenter.sqlite";
            Console.WriteLine(DestDir);
            Console.WriteLine(DestPath);

            // Move the current database to the backup directory
            if(!System.IO.Directory.Exists(DestDir))
            {
                System.IO.Directory.CreateDirectory(DestDir);
            }

            System.IO.File.Copy(SourcePath, DestPath, true);

            // Remove all entries in all of the tables in the database
            try
            {
                foreach(var r in _context.Registrations)
                {
                    _context.Registrations.Remove(r);
                }
                foreach(var s in _context.Students)
                {
                    _context.Students.Remove(s);
                }
                foreach(var s in _context.Subjects)
                {
                    _context.Subjects.Remove(s);
                }
                foreach(var v in _context.Visits)
                {
                    _context.Visits.Remove(v);
                }
                _context.SaveChanges();
                MessageBox.Show("Closing the program....");
                Application.Exit();
            } catch (System.IO.IOException ttt)
            {
                Console.WriteLine(ttt.Message);
                return;
            }

        }

        private void loginTab_Click(object sender, EventArgs e)
        {
            studentLoginForm s = new studentLoginForm();
            s.Show();
        }

        private void studentTab_Click(object sender, EventArgs e)
        {
            studentStats studentStats = new studentStats();
            studentStats.Show();
        }

        private void centerTab_Click(object sender, EventArgs e)
        {
            CenterStatsForm s = new CenterStatsForm();
            s.Show();
        }
    }
}

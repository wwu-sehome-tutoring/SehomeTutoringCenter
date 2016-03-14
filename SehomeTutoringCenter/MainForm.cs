using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SehomeTutoringCenter
{
    public partial class MainForm : Form
    {
        private SehomeContext _context = new SehomeContext();
        private DBHelper _dbh = new DBHelper();

        public MainForm()
        {
            InitializeComponent();

            // The student login page is the default tab, so call these functions to set up some stuff
            PopulateStudentList();
            PopulateClassList();

            // Center Stats page
            PopulateSubjectNames();
            DefaultData();

            // Admin page
            //PopulateGridView();
        }

        private void MainTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MainTabs.SelectedTab == AdminTabPage)
            {
                dataGridView1.Rows.Clear();
                PopulateGridView();
                // Grab the total number of students in the system
                int TotalStudents = _context.Students.Count();
                TotalStudentsBox.Text = TotalStudents.ToString();
            }
            else if(MainTabs.SelectedTab == LoginTabPage)
            {
                NewClassComboBox.Items.Clear();
                PopulateClassList();
            } 
            else if(MainTabs.SelectedTab == StudentTabPage)
            {
                studentComboBox.Items.Clear();
                PopulateStatsNames();
            }
        }


        #region Student Login Page
        // At program start up, fill in the ListBox of the student names that
        // are already in the database, if there are any.
        private void PopulateStudentList()
        {
            foreach (var v in _context.Students)
            {
                var FullName = v.FirstName + " " + v.LastName;
                StudentNamesLogin.Items.Add(FullName);
            }
        }

        // At program start up, fill in the ListBox in the check in area with the 
        // list of classes.
        private void PopulateClassList()
        {
            foreach (var s in _context.Subjects)
            {
                NewClassComboBox.Items.Add(s.Name + "-" + s.TeacherName);
            }
        }

        // Event handling for clicking the new student button
        private void NewStudentButton_Click(object sender, EventArgs e)
        {
            newStudentForm newStudent = new newStudentForm(this);
            newStudent.ShowDialog();
        }

        // Event handling for the Check In button
        private void CheckInButton_Click(object sender, EventArgs e)
        {
            if (!StudentNamesLogin.Text.ToString().Equals(""))
            {
                if (StudentNamesLogin.Text.ToString().Contains("✔"))
                {
                    MessageBox.Show("Already logged in.");
                    return;
                }
                // The chunk of code below will make the class select items pop up
                // and also show the cancel button
                CourseSelectBox.Location = new Point(751, 427);
                CourseSelectBox.Visible = true;

                CheckInVisitButton.Location = new Point(751, 759);
                CheckInVisitButton.Width = 406;
                CheckInVisitButton.Text = "Check In";

                CancelButton.Location = new Point(1164, 759);
                CancelButton.Visible = true;

                NewClassButton.Visible = true;
                NewClassComboBox.Visible = true;

                StudentNamesLogin.Enabled = false;

                // Update the class radio buttons
                ShowStudentClasses();

            }
            else
            {
                MessageBox.Show("Please select a name from the list of students");
            }
        }
        
        // Event handling for the checkout button
        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            if (!StudentNamesLogin.Text.ToString().Equals(""))
            {
                if (!StudentNamesLogin.Text.ToString().Contains("✔"))
                {
                    MessageBox.Show("Not logged in.");
                    return;
                }

                Console.WriteLine("clicked checkout");
                // Grab the selected student and see if they are currently logged in
                string[] names = StudentNamesLogin.Text.ToString().Split(' ');
                string TempFirst = names[0];
                string TempLast = names[1];
                var StudentQuery = from s in _context.Students
                                   where s.FirstName == TempFirst && s.LastName == TempLast
                                   select s;

                var student = StudentQuery.First();

                string CurrentDate = DateTime.Now.ToString().Split(' ')[0];
                string FullName = student.FirstName + " " + student.LastName;

                // Find each visit for the current day
                foreach (var v in _dbh.VisitsFromStudent(_context, student))
                {
                    string date = v.TimeIn.ToString().Split(' ')[0];
                    if (CurrentDate.Equals(date))
                    {
                        // See if the student is logged in for the day
                        if (v.Student.FirstName.Equals(TempFirst) && v.Student.LastName.Equals(TempLast))
                        {
                            v.TimeOut = DateTime.Now;
                            Console.WriteLine("checked out");

                            // Get rid of the checkmark from the students name in the list
                            for (int i = 0; i < StudentNamesLogin.Items.Count; i++)
                            {
                                if (StudentNamesLogin.Items[i].Equals(FullName + " ✔"))
                                {
                                    StudentNamesLogin.Items[i] = FullName;
                                }
                            }
                        }
                    }
                }
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Please select a name from the list of students");
            }
        }

        // Event handling for actually logging in to the system.
        private void CheckInVisitButton_Click(object sender, EventArgs e)
        {
            // Have they selected a class?
            bool HasSelected = false;
            string SelectedClassName = null;
            foreach (Control c in CourseSelectBox.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton r = c as RadioButton;
                    if (r.Checked)
                    {
                        SelectedClassName = r.Text;
                        HasSelected = true;
                    }
                }
            }

            // Create the visit object if a class is selected
            if (HasSelected && CheckInVisitButton.Text.Contains("Check"))
            {
                var SelectedClass = _context.Subjects
                    .Where(s => s.Name == SelectedClassName)
                    .FirstOrDefault();

                // Grab the student object matching the selected name
                string[] names = StudentNamesLogin.Text.ToString().Split(' ');
                string TempFirst = names[0];
                string TempLast = names[1];
                var StudentQuery = from s in _context.Students
                                   where s.FirstName == TempFirst && s.LastName == TempLast
                                   select s;

                var student = StudentQuery.First();
                string FullName = student.FirstName + " " + student.LastName;

                // Create the visit object
                var vis = new Visit
                {
                    TimeIn = DateTime.Now,
                    Student = student,
                    Subject = SelectedClass
                };

                _context.Visits.Add(vis);
                _context.SaveChanges();
                ResetPositions();

                // Finally, update the list of student names in the listbox to indiciate that
                // the student has logged in for this session.
                for (int i = 0; i < StudentNamesLogin.Items.Count; i++)
                {
                    if (StudentNamesLogin.Items[i].Equals(FullName))
                    {
                        StudentNamesLogin.Items[i] = FullName + " ✔";
                    }
                }
            }
            else
            {
                // Need to change this.
                if (!CheckInVisitButton.Text.Contains("Students"))
                {
                    MessageBox.Show("You must select a class.");
                }
            }
        }

        // Event handling for clicking the cancel button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ResetPositions();
        }

        // Event handling for clicking the new class button.  This will add a new registration
        // based on the selected class and the update the radio buttons to show the new class
        private void NewClassButton_Click(object sender, EventArgs e)
        {
            // grab the student object
            string[] names = StudentNamesLogin.Text.ToString().Split(' ');
            string TempFirst = names[0];
            string TempLast = names[1];

            var StudentQuery = from s in _context.Students
                               where s.FirstName == TempFirst && s.LastName == TempLast
                               select s;

            var student = StudentQuery.FirstOrDefault();

            // Check if they have 6 classes already
            if (_dbh.RegistrationsFromStudent(_context, student).Count() > 5)
            {
                MessageBox.Show("Already registered for the maximum number of classes.");
                return;
            }

            // grab the subject object
            string ClassOnly = NewClassComboBox.Text.ToString().Split('-')[0];
            var CurrentClass = _context.Subjects
                                .Where(s => s.Name == ClassOnly)
                                .FirstOrDefault();

            // Check to see if the user is already registered for this class
            bool IsRegistered = false;
            foreach (var r in _context.Registrations)
            {
                if (r.StudentId == student.Id && r.SubjectId == CurrentClass.Id)
                {
                    IsRegistered = true;
                    MessageBox.Show("You are already registered for this class...");
                    return;
                }
            }

            // Create the registration
            if (!IsRegistered)
            {
                var Reg = new Registration
                {
                    Student = student,
                    Subject = CurrentClass
                };
                _context.Registrations.Add(Reg);
                _context.SaveChanges();
            }

            // Update the class radio buttons
            ShowStudentClasses();
        }

        // Helper function to change the radio buttons to match which classes the selected student
        // is registered for.
        private void ShowStudentClasses()
        {
            // Grab the student object
            string[] names = StudentNamesLogin.Text.ToString().Split(' ');
            string TempFirst = names[0];
            string TempLast = names[1];

            var StudentQuery = from s in _context.Students
                               where s.FirstName == TempFirst && s.LastName == TempLast
                               select s;

            var student = StudentQuery.FirstOrDefault();

            // Grab the names of the selected students classes
            ArrayList classes = new ArrayList();
            foreach (var s in _dbh.SubjectsFromStudent(_context, student))
            {
                classes.Add(s.Name);
            }

            // Update the radio buttons to show class names
            int i = 0, y = 0;
            foreach (Control c in CourseSelectBox.Controls)
            {
                if (c is RadioButton)
                {
                    if (i >= (6 - classes.Count))
                    {
                        c.Text = classes[y].ToString();
                        c.Visible = true;
                        y++;
                    }
                    i++;
                }
            }

            // Change the welcome text to match the student name
            WelcomeLabel.Text = String.Format("Welcome {0}, what are you going to study today?", student.FirstName);
        }

        // Function to reset the positions of some of the UI elements
        private void ResetPositions()
        {
            CheckInVisitButton.Location = new Point(751, 439);
            CheckInVisitButton.Text = "Students Subjects";
            CheckInVisitButton.Width = 526;

            CourseSelectBox.Visible = false;

            CancelButton.Visible = false;

            StudentNamesLogin.Enabled = true;
            StudentNamesLogin.ClearSelected();

            NewClassButton.Visible = true;
            NewClassComboBox.Visible = true;

            foreach (Control c in CourseSelectBox.Controls)
            {
                if (c is RadioButton)
                {
                    c.Visible = false;
                }
            }
        }
        #endregion

        #region Student Stats Page
        // Helper function to fill in the combobox in the student stats page
        private void PopulateStatsNames()
        {
            Console.WriteLine("printing...");
            foreach (var s in _context.Students)
            {
                this.studentComboBox.Items.Add(s.FirstName + " " + s.LastName);
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            /*Notes:
            *   
            *
            *To-do:
            *   I think I have an error where I dont display visits with Null time out.
            *   
            */

            //First I clear old values from my pie chart, dataGridView and my currentStudent text.
            studentGridView.Rows.Clear();                   //clear previous values from the datagridview
            foreach (var series in studentPieChart.Series)  //clear the pie chart
            {
                series.Points.Clear();
            }
            currentStudentText.Clear();

            //  Grabing values from the selecting tools on the left side of the page
            string selectedStudentName = studentComboBox.Text.ToString();       //Grab first Last name from studentComboBox
            DateTime startDate = startDatePicker.Value;                         //Selected start date
            DateTime endDate = endDatePicker.Value;                             //Selected start date
            DateTime? timeInNullable;                                           //Visit times from Db
            DateTime? timeOutNullable;
            DateTime timeIn;
            DateTime timeOut;
            TimeSpan visitLength;                                               //This will be the difference between timeIn and timeOut
            string visitDuration;                                               //This will be hh:mm:ss string formate of visitLength
            int classCount = 0;                                                 //This is the number of classes an individual student is registered for
            long[,] subs;                                                       //subs[0][*] = subject Id    and subs[1][*] = Number of vsits for that subject
            string[] subsNames;                                                 //This is the corresponding names for subs[]

            //Add student name to text box
            currentStudentText.Text = selectedStudentName;
            //grabing student object
            string[] names = selectedStudentName.Split(' ');
            string fname = names[0];
            string lname = names[1];

            var StudentQuery = from s in _context.Students
                               where s.FirstName == fname && s.LastName == lname
                               select s;

            var student = StudentQuery.FirstOrDefault();
            //Grabing registered classes
            var registrations = _dbh.RegistrationsFromStudent(_context, student);
            classCount = registrations.Count();
            subs = new long[2, classCount];
            subsNames = new string[classCount];
            int i = 0;
            foreach (var r in registrations)
            {
                subs[0, i] = r.SubjectId;      //at this moment subs holds The id of the registered subject
                var subject = _dbh.SubjectFromRegistration(_context, r);
                subsNames[i] = (subject.Name + ": " + subject.TeacherName);
                i++;
            }
            var visits = _dbh.VisitsFromStudent(_context, student);
            foreach (var visit in visits)
            {
                timeInNullable = visit.TimeIn;
                timeOutNullable = visit.TimeOut;

                timeIn = (DateTime)timeInNullable;

                if (startDate.Day <= timeIn.Day && timeIn.Day <= endDate.Day)
                {
                    for (int c = 0; c < classCount; c++)
                    {
                        if (visit.SubjectId == subs[0, c])
                        {
                            if (timeOutNullable != null)
                            {
                                timeOut = (DateTime)timeOutNullable;
                                subs[1, c] = subs[1, c] + 1;
                                visitLength = timeOut.Subtract(timeIn);
                                visitDuration = visitLength.ToString("hh") + ":" + visitLength.ToString("mm") + ":" + visitLength.ToString("ss");
                                studentGridView.Rows.Add(timeIn.Date.ToString("MMM dd yyyy"), subsNames[c], timeIn.ToString("hh:mm:ss tt"), timeOut.ToString("hh:mm:ss tt"), visitDuration);//.ToString("h m s tt")
                            }
                            else
                            {
                                subs[1, c] = subs[1, c] + 1;
                                studentGridView.Rows.Add(timeIn.Date.ToString("MMM dd yyyy"), subsNames[c], timeIn.ToString("hh:mm:ss tt"), timeOutNullable);
                            }
                        }
                    }
                }
            }
            //
            //  loading pie chart
            //
            for (int c = 0; c < classCount; c++)
            {
                this.studentPieChart.Series["Subjects"].Points.AddXY(subsNames[c], subs[1, c]);
            }
        }

        #endregion

        #region Center Stats Page

        // After the form is created, fill in the subject combobox with the names
        // of all subjects in the database
        private void PopulateSubjectNames()
        {
            foreach (var s in _context.Subjects)
            {
                SubjectComboBox.Items.Add(s.Name);
            }
        }

        // The default view of this form contains information about how many students
        // per day went to the tutoring center for each day of the current semester
        private void DefaultData()
        {
            if (_context.Students.Count() > 0)
            {
                //centerStatsChart.Titles.Add("Students Per Day");

                var VisitCounts = new Dictionary<String, int>();
                int TotalStudents = 0;
                double TotalTime = 0.0;

                // Iterate through all visits and keep track of the count of each date
                TotalStudents = _context.Students.Count();
                // Then go grab all of the unique visit dates and their counts
                foreach (var v in _context.Visits)
                {
                    string DateOnly = v.TimeIn.ToString().Split(' ')[0]; // grab the date 1/30/16, etc.
                    // Now calculate the time spent for this visit
                    DateTime start = (DateTime)v.TimeIn;
                    DateTime end;
                    end = (v.TimeOut == null ? DateTime.Now : (DateTime)v.TimeOut);

                    TimeSpan time = end - start;
                    TotalTime += time.TotalHours;

                    // Add the date and count to the dictionary
                    if (VisitCounts.ContainsKey(DateOnly))
                    {
                        VisitCounts[DateOnly]++;
                    }
                    else
                    {
                        VisitCounts.Add(DateOnly, 1);
                    }
                }

                // Create data arrays to add to a Series later on
                string[] dates = VisitCounts.Keys.ToArray();
                int[] points = VisitCounts.Values.ToArray();

                centerStatsChart.Series[0].IsValueShownAsLabel = true;
                centerStatsChart.Series[0].Points.DataBindXY(dates, "Date", points, "Number of Students");

                // Update the table of center stats information
                TotalStudentsValue.Text = TotalStudents.ToString();
                TotalTimeValue.Text = Math.Round(TotalTime, 2).ToString() + " hours";
                StudentAverageValue.Text = (TotalStudents / VisitCounts.Count).ToString();
                AverageTimeValue.Text = Math.Round((TotalTime / TotalStudents), 2).ToString() + " hours";
            }
            else
            {
                MessageBox.Show("No students in the system.  Can't properly display data.");
            }
        }

        // Helper function to check if a class has been selected and if two dates have been selected
        private bool ValidInput()
        {
            bool IsValid = true;

            return IsValid;
        }

        // Update the chart and table based off of what the user enters as input
        private void CenterGenerateButton_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                var VisitCounts = new Dictionary<String, int>();
                int TotalStudents = 0;
                double TotalTime = 0.0;


                var selected = _context.Subjects
                        .Where(s => s.Name == SubjectComboBox.Text.ToString())
                        .FirstOrDefault();

                // Iterate through all visits that match the class name and date range that
                // the user entered as input.
                foreach (var v in _context.Visits)
                {
                    if (v.Subject.Name.Equals(selected.Name))
                    {
                        string DateOnly = v.TimeIn.ToString().Split(' ')[0]; // grab the date 1/30/16, etc.

                        if (StartDateTimePicker.Value <= v.TimeIn && v.TimeIn <= EndDateTimePicker.Value)
                        {
                            // Now calculate the time spent for this visit
                            DateTime start = (DateTime)v.TimeIn;
                            DateTime end;
                            end = (v.TimeOut == null ? DateTime.Now : (DateTime)v.TimeOut);

                            TimeSpan time = end - start;
                            TotalTime += time.TotalHours;

                            // Add the date and count to the dictionary
                            if (VisitCounts.ContainsKey(DateOnly))
                            {
                                VisitCounts[DateOnly]++;
                                TotalStudents++;
                            }
                            else
                            {
                                VisitCounts.Add(DateOnly, 1);
                                TotalStudents++;
                            }
                        }
                    }
                }

                if (VisitCounts.Count > 0)
                {
                    // Create data arrays to add to a Series later on
                    string[] dates = VisitCounts.Keys.ToArray();
                    int[] points = VisitCounts.Values.ToArray();

                    centerStatsChart.Series[0].IsValueShownAsLabel = true;
                    centerStatsChart.Series[0].Points.DataBindXY(dates, "Date", points, "Number of Students");

                    // Update the table of center stats information
                    TotalStudentsValue.Text = TotalStudents.ToString();
                    TotalTimeValue.Text = Math.Round(TotalTime, 2).ToString() + " hours";
                    StudentAverageValue.Text = (TotalStudents / VisitCounts.Count).ToString();
                    AverageTimeValue.Text = Math.Round((TotalTime / TotalStudents), 2).ToString() + " hours";
                }
                else
                {
                    MessageBox.Show("No visits for this class.  Cannot show data");
                }

            }
            else
            {
                MessageBox.Show("Please select a class and both dates");
            }
        }

        // Select a random student that has a current visit object in the system
        static Random rnd = new Random();
        private void PrizeButton_Click(object sender, EventArgs e)
        {
            string current = DateTime.Now.ToString().Split(' ')[0];
            ArrayList names = new ArrayList();

            // Go to each visit and if it's from today, grab the student and add
            // their name to the list of current student names
            foreach (var v in _context.Visits)
            {
                if (v.TimeIn.ToString().Split(' ')[0].Equals(current))
                {
                    var s = _dbh.StudentFromVisit(_context, v);
                    names.Add(s.FirstName + " " + s.LastName);

                }
            }

            // Now select a random name from the list
            if (names.Count > 0)
            {
                int r = rnd.Next(names.Count);
                RandomNameTextbox.Text = (string)names[r];
            }
            else
            {
                MessageBox.Show("No students for today.  Can't properly display data.");
            }
        }

        #endregion

        #region Admin Page
        // Fill in the table on the admin page
        private void PopulateGridView()
        {
            string current = DateTime.Now.ToString().Split(' ')[0];
            ArrayList names = new ArrayList();

            foreach (var v in _context.Visits)
            {
                if (v.TimeIn.ToString().Split(' ')[0].Equals(current))
                {
                    var s = _dbh.StudentFromVisit(_context, v);

                    DateTime start = (DateTime)v.TimeIn;
                    DateTime end;
                    TimeSpan time;
                    if (v.TimeOut == null)
                    {
                        dataGridView1.Rows.Add(s.FirstName + " " + s.LastName,
                                            _dbh.SubjectFromVisit(_context, v).Name,
                                            start.ToString().Split(' ')[1], '-', '-');
                    }
                    else
                    {
                        end = (DateTime)v.TimeOut;
                        time = end - start;

                        dataGridView1.Rows.Add(s.FirstName + " " + s.LastName,
                                            _dbh.SubjectFromVisit(_context, v).Name,
                                            start.ToString().Split(' ')[1], end.ToString().Split(' ')[1], time);
                    }
                }
            }

        }

        // Set up the file select dialogue I think...
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
                var tokens = line.Split(new char[] { ',' }, 2);
                tokens[1] = tokens[1].Replace("\"", "");

                Console.WriteLine(tokens);

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

        private void NewSemesterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WARNING:  This will delete the current database and create a clean copy of the program.");
            // Grab the current database
            string CWD = Directory.GetCurrentDirectory();
            string SourcePath = CWD + "\\SehomeTutoringCenter.sqlite";
            Console.WriteLine(SourcePath);

            string DestDir = CWD + "\\DatabaseBackups";
            string DestPath = DestDir + "\\SehomeTutoringCenter.sqlite";
            Console.WriteLine(DestDir);
            Console.WriteLine(DestPath);

            // Move the current database to the backup directory
            if (!System.IO.Directory.Exists(DestDir))
            {
                System.IO.Directory.CreateDirectory(DestDir);
            }

            System.IO.File.Copy(SourcePath, DestPath, true);

            // Remove all entries in all of the tables in the database
            try
            {
                foreach (var r in _context.Registrations)
                {
                    _context.Registrations.Remove(r);
                }
                foreach (var s in _context.Students)
                {
                    _context.Students.Remove(s);
                }
                foreach (var s in _context.Subjects)
                {
                    _context.Subjects.Remove(s);
                }
                foreach (var v in _context.Visits)
                {
                    _context.Visits.Remove(v);
                }
                _context.SaveChanges();
                MessageBox.Show("Restarting the program to implement the changes.");
                Application.Exit();
            }
            catch (System.IO.IOException ttt)
            {
                Console.WriteLine(ttt.Message);
                return;
            }
        }

        #endregion


    }
}

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
using System.Windows.Forms.DataVisualization.Charting;

namespace SehomeTutoringCenter
{
    public partial class CenterStatsForm : Form
    {
        private SehomeContext _context = new SehomeContext();
        private DBHelper _dbh = new DBHelper();

        string SelectedClass;
        string StartDate;
        string EndDate;

        public CenterStatsForm()
        {
            InitializeComponent();
            PopulateSubjectNames();
            DefaultData();
        }

        // After the form is created, fill in the subject combobox with the names
        // of all subjects in the database
        private void PopulateSubjectNames()
        {
            foreach (var s in _context.Subjects)
            {
                subjectComboBox.Items.Add(s.Name);
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
            } else
            {
                MessageBox.Show("No students in the system.  Can't properly display data.");
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

        private void adminTab_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            admin.Show();
        }

        // Grab the name of the class when selected
        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedClass = (string)subjectComboBox.SelectedItem;
        }

        // Grab the start date value when selected
        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            StartDate = StartDatePicker.Value.ToString();
        }

        // Grab the end date value when selected
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            EndDate = dateTimePicker1.Value.ToString();
        }

        // Helper function to check if a class has been selected and if two dates have been selected
        private bool ValidInput()
        {
            bool IsValid = true;

            return IsValid;
        }

        // Update the chart and table based off of what the user enters as input
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                var VisitCounts = new Dictionary<String, int>();
                int TotalStudents = 0;
                double TotalTime = 0.0;


                var selected = _context.Subjects
                        .Where(s => s.Name == SelectedClass)
                        .FirstOrDefault();

                // Iterate through all visits that match the class name and date range that
                // the user entered as input.
                foreach (var v in _context.Visits)
                {
                    if (v.Subject.Name.Equals(selected.Name))
                    {
                        string DateOnly = v.TimeIn.ToString().Split(' ')[0]; // grab the date 1/30/16, etc.
                        Console.WriteLine(StartDatePicker.Value);
                        Console.WriteLine(dateTimePicker1.Value);
                        Console.WriteLine(v.TimeIn);

                        if (StartDatePicker.Value <= v.TimeIn && v.TimeIn <= dateTimePicker1.Value)
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

                if (VisitCounts.Count > 0) { 
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
                } else
                {
                    MessageBox.Show("No visits for this class.  Cannot show data");
                }

            } else
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
                if(v.TimeIn.ToString().Split(' ')[0].Equals(current))
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
            } else
            {
                MessageBox.Show("No students for today.  Can't properly display data.");
            }
        }
    }
}

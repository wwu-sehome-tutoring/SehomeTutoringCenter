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
            using (var context = new SehomeContext())
            {
                foreach (var s in context.Subjects)
                {
                    subjectComboBox.Items.Add(s.Name);
                }
            }
        }

        // The default view of this form contains information about how many students
        // per day went to the tutoring center for each day of the current semester
        private void DefaultData()
        {
            centerStatsChart.Titles.Add("Students Per Day");
            var VisitCounts = new Dictionary<String, int>();
            int TotalStudents = 0;
            double TotalTime = 0.0;

            // Iterate through all visits and keep track of the count of each date
            using (var context = new SehomeContext())
            {
                // first grab the total number of students
                TotalStudents = context.Students.Count();
                // then go grab all of the unique visit dates and their counts
                foreach(var v in context.Visits)
                {
                    string DateOnly = v.TimeIn.ToString().Split(' ')[0]; // grab the date 1/30/16, etc.
                    // Now calculate the time spent for this visit
                    DateTime start = (DateTime)v.TimeIn;
                    DateTime end;
                    end = (v.TimeOut == null? DateTime.Now: (DateTime)v.TimeOut);

                    TimeSpan time = end - start;
                    TotalTime += time.TotalHours;

                    // Add the date and count to the dictionary
                    if(VisitCounts.ContainsKey(DateOnly))
                    {
                        VisitCounts[DateOnly]++;
                    } else
                    {
                        VisitCounts.Add(DateOnly, 1);
                    }
                }

                // Create data arrays to add to a Series later on
                string[] dates = VisitCounts.Keys.ToArray();
                int[] points = VisitCounts.Values.ToArray();

                // Create a series which will fill in the chart of dates and their counts
                for(int i = 0; i < dates.Length; i++)
                {
                    Series series = centerStatsChart.Series.Add(dates[i]);
                    series.Points.Add(points[i]);
                }

                // Update the table of center stats information
                TotalStudentsValue.Text = TotalStudents.ToString();
                TotalTimeValue.Text = Math.Round(TotalTime, 2).ToString() + " hours";
                StudentAverageValue.Text = (TotalStudents / VisitCounts.Count).ToString();
                AverageTimeValue.Text = Math.Round((TotalTime / TotalStudents), 2).ToString() + " hours";
            }
        }

        private void loginTab_Click(object sender, EventArgs e)
        {
            studentLoginForm s = new studentLoginForm();

            s.Show();
        }

        private void studentTab_Click(object sender, EventArgs e)
        {

        }

        private void adminTab_Click(object sender, EventArgs e)
        {

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
                centerStatsChart.Titles.Add("Students Per Day");
                var VisitCounts = new Dictionary<String, int>();
                int TotalStudents = 0;
                double TotalTime = 0.0;

                using (var context = new SehomeContext())
                {
                    var selected = context.Subjects
                            .Where(s => s.Name == SelectedClass)
                            .FirstOrDefault();

                    // Iterate through all visits that match the class name and date range that
                    // the user entered as input.
                    foreach (var v in context.Visits)
                    {
                        if (v.Subject.Name.Equals(selected.Name))
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
                                TotalStudents++;
                            }
                            else
                            {
                                VisitCounts.Add(DateOnly, 1);
                                TotalStudents++;
                            }
                        }
                    }

                    // Create data arrays to add to a Series later on
                    string[] dates = VisitCounts.Keys.ToArray();
                    int[] points = VisitCounts.Values.ToArray();

                    // Create a series which will fill in the chart of dates and their counts
                    for (int i = 0; i < dates.Length; i++)
                    {
                        Series series = centerStatsChart.Series.Add(dates[i]);
                        series.Points.Add(points[i]);
                    }

                    // Update the table of center stats information
                    TotalStudentsValue.Text = TotalStudents.ToString();
                    TotalTimeValue.Text = Math.Round(TotalTime, 2).ToString() + " hours";
                    StudentAverageValue.Text = (TotalStudents / VisitCounts.Count).ToString();
                    AverageTimeValue.Text = Math.Round((TotalTime / TotalStudents), 2).ToString() + " hours";

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

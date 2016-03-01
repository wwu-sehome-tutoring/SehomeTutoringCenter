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
    public partial class studentStats : Form
    {
        private SehomeContext _context = new SehomeContext();
        private DBHelper _dbh = new DBHelper();
        public studentStats()
        {
            InitializeComponent();
                foreach (var s in _context.Students)
                {
                    this.studentComboBox.Items.Add(s.FirstName + " " + s.LastName);
                }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void studentStats_Load(object sender, EventArgs e)
        {

        }

        private void subjectGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            
            var StudentQuery =  from s in _context.Students
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
                                visitDuration = visitLength.ToString("hh")+":"+visitLength.ToString("mm")+":"+visitLength.ToString("ss");
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

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endDateGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void startDateGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}

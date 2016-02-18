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
            string selectedStudentName = studentComboBox.Text.ToString();
            //long studentID = -1;                            //This is the student ID from the DB
            currentStudentText.Text = selectedStudentName;
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;
            DateTime? timeInNullable;                               //Question mark means value in Null able
            DateTime? timeOutNullable;
            DateTime timeIn;
            DateTime timeOut;
            //string startDate1 = startDatePicker.Value.ToString("yyyy-MM-dd-0");
            //string endDate1 = endDatePicker.Value.ToString("yyyy-MM-dd");


            int classCount = 0;
            //long[] visitPerSubject;
            long[,] subs;     //subs[0][*] = subject Id    and subs[1][*] = Number of vsits
            string[] subsNames;

            string[] names = selectedStudentName.Split(' ');


            //New code using DBHelper, needs lots of cleaning

            //var StudentQuery =  from s in context.Students
            //                    where s.FirstName == names[0] && s.LastName == names[1]
            //                    select s;

            //var student = StudentQuery.FirstOrDefault();

            foreach (var student in _context.Students)
            {
                if ((student.FirstName + " " + student.LastName) == selectedStudentName)
                {
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
                        //  right now Im counting visits with timeout values before ones with null
                        if (timeOutNullable != null)
                        {
                            timeOut = (DateTime)timeOutNullable;
                            if (startDate <= timeIn && timeIn <= endDate)
                            {
                                for (int c = 0; c < classCount; c++)
                                {
                                    if (visit.SubjectId == subs[0, c])
                                    {
                                        subs[1, c] = subs[1, c] + 1;
                                        studentGridView.Rows.Add(timeIn.Date.ToString("MMM dd yyyy"), subsNames[c], timeIn.ToString("hh:mm:ss tt"), timeOut.ToString("hh:mm:ss tt"), timeOut.Subtract(timeIn));//.ToString("h m s tt")
                                    }
                                }

                            }
                        }
                        else
                        {
                            if (startDate <= timeIn && timeIn <= endDate)
                            {
                                for (int c = 0; c < classCount; c++)
                                {
                                    if (visit.SubjectId == subs[0, c])
                                    {
                                        subs[1, c] = subs[1, c] + 1;
                                        studentGridView.Rows.Add(timeIn.Date.ToString("MMM dd yyyy"), subsNames[c], timeIn.ToString("hh:mm:ss tt"), timeOutNullable);//.ToString("h m s tt")
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
                        //this.chart1.Series["Subjects"].Points.AddXY(subsNames[i], visitPerSubject[i]);
                        this.studentPieChart.Series["Subjects"].Points.AddXY(subsNames[c], subs[1, c]);
                        //Console.Write(i.ToString()+" "+ subs[i].ToString()+"\n");
                    }
                }
            }

            //Ill go through and clean this up as soon as the student.registration NULL error is fixed
            //My atempt at using student.Registraion.
            /*
            using (var context = new SehomeContext())
            {
                var student = new Student{
                            FirstName = "fName",
                            LastName = "lName",
                            Grade = "Sinior"
                        };

                //find the student by first and last name
                foreach (var s in context.Students)
                {
                    if ((s.FirstName + " " + s.LastName) == studentName)
                    {
                        studentID = s.Id;
                        student = s;    //my student object
                    }
                }
                // if I found the student get all the classes they are registered for

                if(student != null)
                {
                    foreach(var r in student.Registrations)
                    {
                        classCount++;   //number of classes and individual student studies
                    }
                    visitPerSubject = new long[classCount];
                    subsNames = new string[classCount];
                   
                    int i = 0;
                    //Collect subject: teacher string for display
                    foreach (var sub in context.Subjects)
                    {
                        subsNames[i] = (sub.Name + ": " + sub.TeacherName);
                        i++;
                    }
                    foreach (var v in student.Visits)//(var v in student.Visits.Where(s => s.student_id = studentID)
                    {
                        if (v.StudentId == studentID)
                        {
                            long subject = v.SubjectId;
                            visitPerSubject[subject - 1]++; //= subs[subject - 1] + 1;
                            dataGridView1.Rows.Add(student, subsNames[unchecked((int)subject) - 1], timeIn, timeOut);
                        }
                    }
                    
                    ///   loading pie chart
                    
                    for (i = 0; i < classCount; i++)
                    {
                        this.chart1.Series["Subjects"].Points.AddXY(subsNames[i], visitPerSubject[i]);
                        //Console.Write(i.ToString()+" "+ subs[i].ToString()+"\n");
                    }
                }
                
                
            }*/

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

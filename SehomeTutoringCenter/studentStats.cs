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
        public studentStats()
        {
            InitializeComponent();
            using (var context = new SehomeContext())
            {
                foreach (var s in context.Students)
                {
                    this.comboBox1.Items.Add(s.FirstName + " " + s.LastName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Notes:
            *   I am assuming that the IDs in the subject table start at 1 and are consecutive
            *   When counting the number of subjects that a student has studied for I use an array where the indices are the subject IDs
            *
            *To-do:
            *   I still need to filter by date and time
            *   other stuff
            */

            dataGridView1.Rows.Clear();/*clear previous values from the datagridview*/
            foreach (var series in chart1.Series)/*clear the pie chart*/
            {
                series.Points.Clear();
            }
            /*  Grabing values from the selecting tools on the left side of the page*/
            string studentName = comboBox1.Text.ToString();
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker1.Value;
            string startDate1 = dateTimePicker1.Value.ToString("yyyy-MM-dd-0");
            string endDate1 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            //Console.WriteLine(student);
            //Console.WriteLine(startDate);
            //Console.WriteLine(endDate);
            long studentID = -1;
            int classCount = 0;
            //long[] visitPerSubject;
            long[] subs;
            string[] subsNames;
            /*need to change this*/

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


            /// Current working code
            using (var context = new SehomeContext())
            {
                //COunt number of different class/teacher pairs in Subjects table
                foreach (var sub in context.Subjects)
                {
                    classCount++;
                }
                subs = new long[classCount];
                subsNames = new string[classCount];
                int i = 0;
                foreach (var sub in context.Subjects)
                {
                    subsNames[i] = (sub.Name + ": " + sub.TeacherName);
                    i++;
                }
                foreach (var s in context.Students)
                {
                    if ((s.FirstName + " " + s.LastName) == studentName)
                    {
                        studentID = s.Id;
                    }
                }
                foreach (var v in context.Visits)
                {
                    if (v.StudentId == studentID)
                    {

                        //string timeIn = v.TimeIn.ToString();
                        //string timeOut = v.TimeOut.ToString();

                        DateTime? timeIn = v.TimeIn;
                        DateTime? timeOut = v.TimeOut;
                        //if (startDate <= timeIn && timeIn<= endDate)

                        long subject = v.SubjectId;
                        subs[subject - 1] = subs[subject - 1] + 1;
                        dataGridView1.Rows.Add(studentName, subsNames[unchecked((int)subject) - 1], timeIn, timeOut);


                    }
                }
            }
            /*
            *   loading pie chart
            */
            for (int i = 0; i < classCount; i++)
            {
                //this.chart1.Series["Subjects"].Points.AddXY(subsNames[i], visitPerSubject[i]);
                this.chart1.Series["Subjects"].Points.AddXY(subsNames[i], subs[i]);
                //Console.Write(i.ToString()+" "+ subs[i].ToString()+"\n");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void studentStats_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehomeTutoringCenter
{
    public partial class adminForm : Form
    {
        private SehomeContext _context = new SehomeContext();
        public adminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addSubject_Click()
        {

        }

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

        private void NewSemesterButton_Click(object sender, EventArgs e)
        {

        }

        private void loginTab_Click(object sender, EventArgs e)
        {

        }

        private void studentTab_Click(object sender, EventArgs e)
        {

        }

        private void centerTab_Click(object sender, EventArgs e)
        {

        }
    }
}

/// This contains the main() method which will run the Form and
/// maintain the application.
using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SehomeTutoringCenter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string CWD = Directory.GetCurrentDirectory();
            string DBPath = CWD + "\\SehomeTutoringCenter.sqlite";
            System.Diagnostics.Debug.WriteLine(DBPath);
            if (!(System.IO.File.Exists(DBPath)))
            {
                System.Diagnostics.Debug.WriteLine("DataBase Doesn't Exist");
                CreateDB();
                //Application.Exit();
                //CreateDB();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Database already exists");
            }
            SQLiteConnection SehomeDB;
            SehomeDB = new SQLiteConnection("Data Source=SehomeTutoringCenter.sqlite;");

            // Generate Test Data
            GenerateTestData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new studentLoginForm());
        }

        static void CreateDB()
        {
            SQLiteConnection.CreateFile("SehomeTutoringCenter.sqlite");

            SQLiteConnection SehomeDB;
            SehomeDB = new SQLiteConnection("Data Source=SehomeTutoringCenter.sqlite;");
            SehomeDB.Open();

            string query = @"PRAGMA foreign_keys = ON;

CREATE TABLE student(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    first_name TEXT NOT NULL,
    last_name TEXT NOT NULL,
    grade TEXT NOT NULL
);

CREATE TABLE subject(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    teacher_name TEXT NOT NULL
);

CREATE TABLE registration(
    student_id INTEGER NOT NULL,
    subject_id INTEGER NOT NULL,
    FOREIGN KEY(student_id) REFERENCES student(id),
    FOREIGN KEY(subject_id) REFERENCES subject(id),
    PRIMARY KEY(student_id, subject_id)
);

CREATE TABLE visit(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    time_in TEXT DEFAULT CURRENT_TIMESTAMP,
    time_out TEXT DEFAULT NULL,
    student INTEGER NOT NULL,
    subject INTEGER NOT NULL,
    FOREIGN KEY(student) REFERENCES student(id),
    FOREIGN KEY(subject) REFERENCES subject(id)
);";
            SQLiteCommand command = new SQLiteCommand(query, SehomeDB);
            command.ExecuteNonQuery();
        }

        static void GenerateTestData()
        {
            using (var context = new SehomeContext())
            {
                // Generate test students
                String[,] testStudents = new String[11, 2]
                {
                    { "Patrick", "Tolley" },
                    { "Tucker", "Siemens" },
                    { "JJ", "Small" },
                    { "Nathan", "Shive" },
                    { "Andrew", "Feely" },
                    { "Elvis", "Presley" },
                    { "Aran", "Clauson" },
                    { "Brenda", "Apt" },
                    { "Master", "Chief" },
                    { "Malcolm", "Reynolds" },
                    { "William", "Adama" }
                };

                // Create objects for each test student
                for (int i = 0; i < testStudents.GetLength(0); i++)
                {
                    var student = new Student
                    {
                        FirstName = testStudents[i, 0],
                        LastName = testStudents[i, 1],
                        Grade = "Senior"
                    };
                    context.Students.Add(student);
                }

                // Save test students
                context.SaveChanges();

                // Generate test subjects
                String[,] testSubjects = new String[11, 2]
                {
                    { "Algebra 1", "Johnson" },
                    { "Algebra 1", "Hearne" },
                    { "Algebra 2", "Johnson" },
                    { "American History", "Fizzano" },
                    { "Computer Programming", "Clauson" },
                    { "Drama", "Zhang" },
                    { "Health", "Hutchinson" },
                    { "Typing", "Clauson" },
                    { "Underwater Basket Weaving", "Rrushi" },
                    { "Home Economics", "Matthews" },
                    { "Woodworking", "Meehan" }
                };

                // Create objects for each test subject
                for (int i = 0; i < testSubjects.GetLength(0); i++)
                {
                    var subject = new Subject
                    {
                        Name = testSubjects[i, 0],
                        TeacherName = testSubjects[i, 1]
                    };
                    context.Subjects.Add(subject);
                }

                // Save test subjects
                context.SaveChanges();

                // Generate test registrations
                var subjects = context.Subjects
                               .Where(s => s.Name == "Underwater Basket Weaving" || s.Name == "Computer Programming");

                foreach (var stu in context.Students)
                {
                    foreach (var sub in subjects)
                    {
                        var reg = new Registration
                        {
                            Student = stu,
                            Subject = sub
                        };

                        context.Registrations.Add(reg);
                    }
                }

                // Save test registrations
                context.SaveChanges();

                // Generate test visits
                foreach (var stu in context.Students)
                {
                    foreach (var reg in stu.Registrations)
                    {
                        var vis = new Visit
                        {
                            TimeIn = DateTime.Now.AddMinutes(-10.0),
                            TimeOut = DateTime.Now.AddMinutes(10.0),
                            Student = stu,
                            Subject = reg.Subject
                        };

                        context.Visits.Add(vis);
                    }
                }

                // Save test visits
                context.SaveChanges();

            }
        }
    }
}
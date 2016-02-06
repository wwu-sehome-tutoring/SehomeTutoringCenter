/// This contains the main() method which will run the Form and
/// maintain the application.
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
            using (var context = new SehomeContext())
            {
                //InsertDummyStudents(context);
                //InsertDummySubjects(context);
            }
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

        static void InsertDummyStudents(SehomeContext context)
        {
            String[,] dummyNames = new String[10, 2];

            dummyNames[0, 0] = "Patrick";
            dummyNames[0, 1] = "Tolley";
            dummyNames[1, 0] = "Tucker";
            dummyNames[1, 1] = "Siemens";
            dummyNames[2, 0] = "JJ";
            dummyNames[2, 1] = "Small";
            dummyNames[3, 0] = "Andrew";
            dummyNames[3, 1] = "Feely";
            dummyNames[4, 0] = "Nathan";
            dummyNames[4, 1] = "Shive";
            dummyNames[5, 0] = "Elvis";
            dummyNames[5, 1] = "Presley";
            dummyNames[6, 0] = "Aaron";
            dummyNames[6, 1] = "Clausen";
            dummyNames[7, 0] = "Brenda";
            dummyNames[7, 1] = "Apt";
            dummyNames[8, 0] = "Master";
            dummyNames[8, 1] = "Chief";
            dummyNames[9, 0] = "Tutor";
            dummyNames[9, 1] = "User";

            for (int i = 0; i < 10; i++)
            {
                var Stud = new Student
                {
                    FirstName = dummyNames[i, 0],
                    LastName = dummyNames[i, 1],
                    Grade = "Senior"
                };
                context.Students.Add(Stud);
            }
            context.SaveChanges();
        }
        static void InsertDummySubjects(SehomeContext context)
        {
            String[,] dummySubjects = new String[10, 2];
            dummySubjects[0, 0] = "Algebra1";
            dummySubjects[0, 1] = "Johnson";
            dummySubjects[1, 0] = "Algebra2";
            dummySubjects[1, 1] = "Johnson";
            dummySubjects[2, 0] = "American History";
            dummySubjects[2, 1] = "Williams";
            dummySubjects[3, 0] = "Computer Programming";
            dummySubjects[3, 1] = "Smith";
            dummySubjects[4, 0] = "Drama";
            dummySubjects[4, 1] = "Jones";
            dummySubjects[5, 0] = "Health";
            dummySubjects[5, 1] = "Brown";
            dummySubjects[6, 0] = "Typing";
            dummySubjects[6, 1] = "Davis";
            dummySubjects[7, 0] = "Sitting";
            dummySubjects[7, 1] = "Miller";
            dummySubjects[8, 0] = "Home Economics";
            dummySubjects[8, 1] = "Wilson";
            dummySubjects[9, 0] = "Woodworking";
            dummySubjects[9, 1] = "Moore";

            for (int i = 0; i < 10; i++)
            {
                var Sub = new Subject
                {
                    Name = dummySubjects[i, 0],
                    TeacherName = dummySubjects[i, 1]
                };
                context.Subjects.Add(Sub);
            }
            context.SaveChanges();
        }
    }

}
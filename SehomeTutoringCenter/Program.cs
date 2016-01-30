/// This contains the main() method which will run the Form and
/// maintain the application.
using System;
using System.Collections.Generic;
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
            using (var context = new SehomeContext())
            {
                //InsertDummyStudents(context);
                InsertDummySubjects(context);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new studentLoginForm());
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
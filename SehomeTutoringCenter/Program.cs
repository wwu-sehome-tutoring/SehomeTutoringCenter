/// This contains the main() method which will run the Form and
/// maintain the application.
using System;
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
            DummyClassData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new studentLoginForm());
        }

        static private void DummyClassData()
        {
            using (var context = new SehomeContext())
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
}
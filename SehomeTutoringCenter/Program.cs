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
                InsertDummyStudents(context);
                InsertDummySubjects(context);
                InsertDummyVisitsAndRegistrations(context);
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

        public static void InsertDummyVisitsAndRegistrations(SehomeContext context)
        {
            // Get all students with the first name "JJ".
            var firstNameWithJJ = from s in context.Students
                     where s.FirstName == "JJ"
                     select s;

            // Get all subjects taught by a teacher with the name "Smith".
            var subjectFromSmith = from s in context.Subjects
                          where s.TeacherName == "Smith"
                          select s;

            // Get the first subject with the name "Woodworking".
            var woodworking = context.Subjects
                .Where(s => s.Name == "Woodworking")
                .First();

            // Get the first student whose name begins with "JJ".
            var JJ = firstNameWithJJ.First();

            //Get the first course taught by a teacher with the name "Smith".
            var computerProgramming = subjectFromSmith.First();

            // Create a registration for JJ in Computer Programming.
            var registration1 = new Registration
            {
                Student = JJ,
                Subject = computerProgramming
            };

            // Create a registration for JJ in Woodworking.
            var registration2 = new Registration
            {
                Student = JJ,
                Subject = woodworking 
            };

            // Add the registrations to the database.
            context.Registrations.Add(registration1);
            context.Registrations.Add(registration2);
            context.SaveChanges();

            // Create a visit to the center by JJ for Computer Programming.
            var visit = new Visit
            {
                TimeIn = DateTime.Now,
                TimeOut = DateTime.Now,
                Student = JJ,
                Subject = computerProgramming
            };

            // Add the visit to the database.
            context.Visits.Add(visit);
            context.SaveChanges();

            // List all the courses JJ is registered for.
            Console.WriteLine("JJ is registered for:");
            foreach (var r in JJ.Registrations)
            {
                String output = String.Format("{0} taught by {1}",
                                              r.Subject.Name,
                                              r.Subject.TeacherName);
                Console.WriteLine(output);
            }

            // Report the name and check in time for each of JJ's visits.
            foreach (var v in JJ.Visits)
             {
                String output = String.Format("JJ checked in for {0} at {1}.",
                                              v.Subject.Name,
                                              v.TimeIn);
                Console.WriteLine(output);
            }

        }
    }

}
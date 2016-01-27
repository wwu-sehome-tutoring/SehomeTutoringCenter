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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new studentLoginForm());
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

            // Create a visit with no TimeIn or TimeOut fields.
            // TimeIn will default to DateTime.Now, TimeOut remains null.
            var visit2 = new Visit
            {
                Student = JJ,
                Subject = woodworking
            };

            // Add the visit to the database.
            context.Visits.Add(visit);
            context.Visits.Add(visit2);
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
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehomeTutoringCenter
{
    class DBHelper
    {
        public DBHelper()
        {
        }

        // Student Methods ---------------------------------------------------------------------

        // RegistrationsFromStudent returns a queryable set of Registrations given a Student and a SehomeContext.
        public IQueryable<Registration> RegistrationsFromStudent(SehomeContext context, Student student)
        {
            return context.Registrations.Where(r => r.StudentId == student.Id);
        }

        // VisitsFromStudent returns a queryable set of Visits given a Student and a SehomeContext.
        public IQueryable<Visit> VisitsFromStudent(SehomeContext context, Student student)
        {
            return context.Visits.Where(v => v.StudentId == student.Id);
        }

        // SubjectsFromStudent returns a queryable set of Subjects given a Student and a SehomeContext.
        public IQueryable<Subject> SubjectsFromStudent(SehomeContext context, Student student)
        {
            var subjects = new List<Subject>();
            foreach (var r in RegistrationsFromStudent(context, student))
            {
                subjects.Add(SubjectFromRegistration(context, r));
            }
            return subjects.AsQueryable();
        }

        // Registration Methods ----------------------------------------------------------------

        // StudentFromRegistration returns a Student given a Registration and a SehomeContext.
        public Student StudentFromRegistration(SehomeContext context, Registration registration)
        {
            return context.Students.Where(s => s.Id == registration.StudentId).First();
        }

        // SubjectFromRegistration returns a Subject given a Registration and a SehomeContext.
        public Subject SubjectFromRegistration(SehomeContext context, Registration registration)
        {
            return context.Subjects.Where(s => s.Id == registration.SubjectId).First();
        }

        // Visit Methods -----------------------------------------------------------------------

        // StudentFromVisit returns a Student given a Visit and a SehomeContext.
        public Student StudentFromVisit(SehomeContext context, Visit visit)
        {
            return context.Students.Where(s => s.Id == visit.StudentId).First();
        }

        // SubjectFromVisit returns a Subject given a Visit and a SehomeContext.
        public Subject SubjectFromVisit(SehomeContext context, Visit visit)
        {
            return context.Subjects.Where(s => s.Id == visit.SubjectId).First();
        }
    }
}

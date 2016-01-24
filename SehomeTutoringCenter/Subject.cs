using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehomeTutoringCenter
{
    class Subject
    {
        public Subject()
        {
        }

        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("teacher_name")]
        public string TeacherName { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}

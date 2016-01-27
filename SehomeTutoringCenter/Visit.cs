using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehomeTutoringCenter
{
    class Visit
    {
        public Visit()
        {
        }

        [Column("id")]
        public long Id { get; set; }

        private DateTime? timeIn = null;

        [Column("time_in")]
        public DateTime? TimeIn
        {
            get
            {
                return this.timeIn.HasValue
                    ? this.timeIn.Value
                    : DateTime.Now;
            }

            set { this.timeIn = value; }
        }

        [Column("time_out")]
        public DateTime? TimeOut { get; set; }

        [Column("student_id")]
        public long StudentId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        [Column("subject_id")]
        public long SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
    }
}

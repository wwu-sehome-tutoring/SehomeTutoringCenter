using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehomeTutoringCenter
{
    class Registration
    {
        [Key, Column("student_id", Order = 0)]
        public long StudentId { get; set; }

        [Key, Column("subject_id", Order = 1)]
        public long SubjectId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
    }
}

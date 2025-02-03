using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDAL.Modules
{
    public class Subject
    {
        [Key]

        public int SubjectID { get; set; }
        [Column(TypeName = "varchar"), StringLength(50)]

        public string SubjectName { get; set; }
        public virtual List<Teacher> Teachers { get; } = new List<Teacher>();
        public virtual List<TeacherClassSubject> lesson { get; } = new List<TeacherClassSubject>();
        public virtual List<Degree> studentdegrees { get; } = new List<Degree>();
    }
}

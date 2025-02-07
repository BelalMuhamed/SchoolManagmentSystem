using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Modules
{
    public class Teacher
    {
        [Key]

        public int TeacherID { get; set; }
        [Column(TypeName = "varchar"), StringLength(50)]

        public string FirstName { get; set; }
        [Column(TypeName = "varchar"), StringLength(50)]

        public string LastName { get; set; }
        [Column(TypeName = "date")]

        public DateTime BirthDate { get; set; }
        [Column(TypeName = "varchar"), StringLength(7)]

        public string Gender { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Column(TypeName = "date")]
        public DateTime HireDate { get; set; }
        [ForeignKey("Subject")]
        public int? SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual List<Class> Classes { get;  }=new List<Class>();
        public virtual List<TeacherClassSubject> lesson { get; } = new List<TeacherClassSubject>();
        public virtual List<TeacherAttendance> teachersattend { get; } = new List<TeacherAttendance>();
    }
}

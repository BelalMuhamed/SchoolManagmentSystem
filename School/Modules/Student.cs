using SchoolDAL.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Modules
{
    public class Student
    {
        [Key]

        public int StudentID { get; set; }
        [Column(TypeName = "varchar"), StringLength(50)]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar"), StringLength(50)]
        public string LastName { get; set; }
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }
        [Column(TypeName = "varchar"), StringLength(7)]

        public string Gender { get; set; }
        [Column(TypeName = "varchar"), StringLength(50)]

        public string Address { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Column(TypeName = "date")]

        public DateTime EnrollmentDate { get; set; }
        [ForeignKey("Class")]
        public int classId { get; set; }
        public virtual Class Class { get; set; }
        public virtual List<Degree> studentdegrees { get; } = new List<Degree>();
        public virtual List<StudentAttendance> studentAttend { get; } = new List<StudentAttendance>();


    }
}

using School.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Modules
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }
        [Column(TypeName = "varchar"), StringLength(50)]

        public string ClassName { get; set; }
        [ForeignKey("Manager")]
        public int? ManagerId { get; set; }
        public virtual Teacher Manager { get; set; }
        public virtual List<TeacherClassSubject> lesson { get; } = new List<TeacherClassSubject>();
        public virtual List<Student> Students { get; } = new List<Student>();
     

    }
}

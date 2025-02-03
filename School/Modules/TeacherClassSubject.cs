using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Modules;
using System.Windows.Forms;

namespace SchoolDAL.Modules
{
    [PrimaryKey(nameof(date), nameof(Lesson))]

    public class TeacherClassSubject
    {
       
        public DateTime date { get; set; }
       
        public string Lesson { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        [ForeignKey("classs")]

        public int classId { get; set; }
        [ForeignKey("Subject")]

        public int SubjectId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual Subject? Subject { get; set; }
        public virtual Class classs { get; set; }
    }
}

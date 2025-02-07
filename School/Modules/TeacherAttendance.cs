using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Modules;

namespace School.Modules
{
    [PrimaryKey(nameof(day), nameof(TeacherId))]

    public class TeacherAttendance
    {
        [ Column(TypeName = "date")]
        public DateTime day { get; set; }
        [ ForeignKey("teacher")]
        public int TeacherId { get; set; }
        public string status { get; set; }
        public virtual Teacher teacher { get; set; }
      
    }
}

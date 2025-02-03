using School.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SchoolDAL.Modules
{
    [PrimaryKey(nameof(StudentId), nameof(day))]
    public class StudentAttendance
    {
        [ Column(TypeName = "date")]
        public DateTime day { get; set; }
         [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ ForeignKey("Classs")]

       
        public string status { get; set; }
        public virtual Student Student { get; set; }
       

    }
}

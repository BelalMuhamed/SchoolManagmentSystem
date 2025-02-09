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
    public class Degree
    {
        [Key]
        public int DegreeId { get; set; }
        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        [ForeignKey("subject")]
        public int? SubId { get; set; }
        [Column(TypeName = "money")]
        public decimal? mark { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject subject { get; set; }
    }
}

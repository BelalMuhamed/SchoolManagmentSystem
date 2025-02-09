using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.VM
{
    public class DegreeViewModel
    {
        public int DegreeId { get; set; }
        
        public int? StudentId { get; set; }
        
        public int? SubId { get; set; }
       
        public decimal? mark { get; set; }
         public string studentname {  get; set; }
      


    }
}

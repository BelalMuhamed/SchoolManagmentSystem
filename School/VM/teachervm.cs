using School.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.VM
{
    public class teachervm
    {
       

        public int TeacherID { get; set; }
       

        public string FirstName { get; set; }
        

        public string LastName { get; set; }
        

        public DateTime BirthDate { get; set; }
        

        public string Gender { get; set; }
        
        public string Phone { get; set; }
        
        public string Email { get; set; }
       
        public DateTime HireDate { get; set; }
        
        public int? SubjectID { get; set; }
        public  string SubjectName { get; set; }
    }
}

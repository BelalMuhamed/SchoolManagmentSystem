using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.VM
{
    public class LessonDetail
    {
        public int classid { get; set; }
        public int subjectid { get; set; }
        public DateTime Date { get; set; }
        public string ClassName { get; set; }
        public string Lesson { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20190730EFCoreProgram.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string EName { get; set; }
        public virtual IEnumerable<ArrangeCourse> ArrangeCourses { get; set; }

    }
}

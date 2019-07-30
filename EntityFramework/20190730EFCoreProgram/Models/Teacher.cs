using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20190730EFCoreProgram.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public int CName { get; set; }
        public int EName { get; set; }

        public IEnumerable<ArrangeCourse> ArrangeCourses { get; set; }
    }
}

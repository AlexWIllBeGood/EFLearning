using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20190730EFCoreProgram.Models
{
    public class ArrangeCourse
    {
        public int Id { get; set; }
        public int CName { get; set; }
        public int EName { get; set; }
        public virtual int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _20190730EFCoreProgram.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string CName { get; set; }
        public virtual ICollection<ArrangeCourse> ArrangeCourses { get; set; }
    }
}

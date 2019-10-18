using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _20190730EFCoreProgram.Models
{
    public class ArrangeCourse
    {
        public int Id { get; set; }
        [MaxLength(300)]
        public string CName { get; set; }
        [ForeignKey("Teacher")]
        public virtual int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        [ForeignKey("Student")]
        public virtual int StudentId { get; set; }
        public virtual Student Student { get; set; }
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst20190708.Models
{
    public class ArrangeCourse
    {
        [Key]
        public int ArrangeCourseId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        //手动指定外键
        //[ForeignKey("Student")]
        //public int TempStudentId { get; set; }
        //[ForeignKey("Teacher")]
        //public int TempTeacherId { get; set; }
        public int CourseId { get; set; }
        //[ForeignKey("TempStudentId")]
        public virtual Student Student { get; set; }
        //[ForeignKey("TempTeacherId")]
        public virtual Teacher Teacher { get; set; }
        public int Status { get; set; }
    }
}

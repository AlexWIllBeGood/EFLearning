using System;
using System.Collections.Generic;
using System.Text;

namespace StandardModels.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //导航属性
        public virtual ICollection<ArrangeCourse> ArrangeCourses { get; set; }
    }
}

using StandardModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardModels.Dtos
{
    public class StudentChildDto:Student
    {
        //导航属性
        public virtual ICollection<ArrangeCourse> ArrangeCourses { get; set; }
    }
}

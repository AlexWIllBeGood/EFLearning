using StandardModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardModels.Dtos
{
    public class TeacherChildDto:Teacher
    {
        /// <summary>
        /// 导航属性
        /// </summary>
        public virtual ICollection<ArrangeCourse> ArrangeCourses { get; set; }
    }
}

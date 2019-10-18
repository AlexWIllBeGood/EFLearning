using System;
using System.Collections.Generic;
using System.Text;

namespace StandardModels.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// 导航属性
        /// </summary>
        public virtual ICollection<ArrangeCourse> ArrangeCourses { get; set; }
    }
}

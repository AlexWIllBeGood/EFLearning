using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi20191018.Models
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StandardModels.Models
{
    public class ArrangeCourse
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Description("主键ID")]
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        #region 导航属性
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }
        #endregion
    }
}

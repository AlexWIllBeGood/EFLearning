using CodeFirst20190708.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst20190708.ModelConfigs
{
    public class ArrangeCourseConfig:EntityTypeConfiguration<ArrangeCourse>
    {
        public ArrangeCourseConfig()
        {
            ToTable("ArrangeCourse");
            Property(e => e.ArrangeCourseId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            //Property(e => e.StudentId).IsRequired();
            //Property(e => e.TeacherId).IsRequired();
            Property(e => e.CourseId).IsRequired();
        }
    }
}

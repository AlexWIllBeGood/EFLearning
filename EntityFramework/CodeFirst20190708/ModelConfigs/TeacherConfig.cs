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
    public class TeacherConfig:EntityTypeConfiguration<Teacher>
    {
        public TeacherConfig()
        {
            ToTable("Teacher");
            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(e => e.Name).HasMaxLength(100);
        }
    }
}

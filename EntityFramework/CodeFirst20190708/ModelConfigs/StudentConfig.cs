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
    public class StudentConfig:EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            ToTable("Student");
            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(e => e.Name).HasMaxLength(1000);
        }
    }
}

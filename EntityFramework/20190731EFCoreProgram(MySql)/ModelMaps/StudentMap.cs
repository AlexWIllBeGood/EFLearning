using _20190731EFCoreProgram_MySql_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20190731EFCoreProgram_MySql_.ModelMaps
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(300);
            builder.Property(e => e.Age).IsRequired();
            builder.Property(e => e.IsDeleted).HasColumnType("bit");
        }
    }
}

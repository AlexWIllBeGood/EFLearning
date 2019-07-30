using _20190730EFCoreProgram.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20190730EFCoreProgram.Maps
{
    public class TeacherMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            
            builder.ToTable("Teacher");
            builder.HasKey(e => e.Id);
            //建立一对多关系
            //builder.HasMany(e => e.ArrangeCourses)
            //    .WithOne(e => e.Teacher)
            //    .HasForeignKey(e => e.TeacherId);
            builder.Property(e => e.Id).UseSqlServerIdentityColumn();
        }
    }
}

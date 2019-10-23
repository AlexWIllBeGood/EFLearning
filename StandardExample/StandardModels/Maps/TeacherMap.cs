using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StandardModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardModels.Maps
{
    public class TeacherMap:IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("TeacherTest");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseMySqlIdentityColumn();
            //builder.HasMany(e => e.ArrangeCourses)
            //    .WithOne(e => e.Teacher)
            //    .HasForeignKey(e => e.TeacherId);
        }
    }
}

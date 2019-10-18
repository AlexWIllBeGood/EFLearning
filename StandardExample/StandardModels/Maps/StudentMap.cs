using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StandardModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardModels.Maps
{
    public class StudentMap:IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("StudentTest");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseMySqlIdentityColumn();
            builder.HasMany(e => e.ArrangeCourses)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId);
        }
    }
}

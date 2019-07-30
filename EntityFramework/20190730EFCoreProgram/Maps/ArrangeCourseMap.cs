using _20190730EFCoreProgram.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20190730EFCoreProgram.Maps
{
    public class ArrangeCourseMap : IEntityTypeConfiguration<ArrangeCourse>
    {
        public void Configure(EntityTypeBuilder<ArrangeCourse> builder)
        {
            builder.ToTable("ArrangeCourse");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseSqlServerIdentityColumn();
        }
    }
}

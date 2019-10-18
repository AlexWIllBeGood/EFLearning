using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StandardModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardModels.Maps
{
    public class ArrangeCourseMap:IEntityTypeConfiguration<ArrangeCourse>
    {
        public void Configure(EntityTypeBuilder<ArrangeCourse> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseMySqlIdentityColumn();
        }
    }
}

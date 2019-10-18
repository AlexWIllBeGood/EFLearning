using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi20191018.Models;

namespace WebApi20191018.Maps
{
    public class ArrangeCourseMap : IEntityTypeConfiguration<ArrangeCourse>
    {
        public void Configure(EntityTypeBuilder<ArrangeCourse> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseMySqlIdentityColumn();
        }
    }
}

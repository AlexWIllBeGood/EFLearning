using _20190730EFCoreProgram.Maps;
using _20190730EFCoreProgram.Models;
using _20190730EFCoreProgram.SysModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace _20190730EFCoreProgram.Context
{
    public class LocalContext:DbContext
    {
        
        public LocalContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("Data Source=127.0.0.1;port=3306;Initial Catalog=metenword;user id=root;password=123456;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Teacher>(new TeacherMap());
            modelBuilder.ApplyConfiguration<Student>(new StudentMap());
            modelBuilder.ApplyConfiguration<ArrangeCourse>(new ArrangeCourseMap());
        }
    }
}

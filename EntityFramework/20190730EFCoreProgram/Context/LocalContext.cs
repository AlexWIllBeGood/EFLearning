using _20190730EFCoreProgram.Maps;
using _20190730EFCoreProgram.Models;
using Microsoft.EntityFrameworkCore;
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
            string mysqlConnStr = ConfigurationManager.ConnectionStrings["mysqlConn"].ToString();
            optionsBuilder.UseMySQL("mysqlConnStr");
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

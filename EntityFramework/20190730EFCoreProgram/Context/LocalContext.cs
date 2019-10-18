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
            optionsBuilder.UseMySQL("Data Source=127.0.0.1;port=3306;Initial Catalog=TestDb;user id=root;password=123456;");
        }
        public DbSet<Student> students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration<Teacher>(new TeacherMap());
            //modelBuilder.ApplyConfiguration<Student>(new StudentMap());
            //modelBuilder.ApplyConfiguration<ArrangeCourse>(new ArrangeCourseMap());

            var students = new List<Student>() {
                new Student(){ CName="Alex"},
                new Student(){ CName="Jane"},
                new Student(){ CName="Jason"}
            };
            modelBuilder.Entity<Student>().HasData(students);

            //var teachers = new List<Teacher>()
            //{
            //    new Teacher(){ CName="Bob"},
            //    new Teacher(){ CName="Bill"}
            //};
            //modelBuilder.Entity<Teacher>().HasData(teachers);

            //var arrangeCourses = new List<ArrangeCourse>()
            //{
            //    new ArrangeCourse(){ CName="lesson1",StudentId=students[0].Id,TeacherId=teachers[0].Id},
            //    new ArrangeCourse(){ CName="lesson1",StudentId=students[1].Id,TeacherId=teachers[0].Id},
            //    new ArrangeCourse(){ CName="lesson1",StudentId=students[2].Id,TeacherId=teachers[0].Id},
            //    new ArrangeCourse(){ CName="lesson2",StudentId=students[0].Id,TeacherId=teachers[1].Id},
            //    new ArrangeCourse(){ CName="lesson2",StudentId=students[1].Id,TeacherId=teachers[1].Id},
            //    new ArrangeCourse(){ CName="lesson2",StudentId=students[2].Id,TeacherId=teachers[1].Id},
            //};
            //modelBuilder.Entity<ArrangeCourse>().HasData(arrangeCourses);
        }
    }
}

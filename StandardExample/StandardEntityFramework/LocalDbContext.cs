using Microsoft.EntityFrameworkCore;
using StandardModels.Maps;
using StandardModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardEntityFramework
{
    public class LocalDbContext:DbContext
    {
        #region ArrangeCourse

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ArrangeCourse> ArrangeCourses { get; set; }

        #endregion

        public LocalDbContext(DbContextOptions<LocalDbContext> options) : base(options)
        {
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL("");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TeacherMap());
            modelBuilder.ApplyConfiguration(new StudentMap());
            modelBuilder.ApplyConfiguration(new ArrangeCourseMap());

            var students = new List<Student>()
            {
                new Student(){ Id=1,Name="s1"},
                new Student(){ Id=2,Name="s2"},
                new Student(){ Id=3,Name="s3"},
                new Student(){ Id=4,Name="s4"},
                new Student(){ Id=5,Name="s5"}
            };
            modelBuilder.Entity<Student>().HasData(students);

            var teachers = new List<Teacher>()
            {
                new Teacher(){ Id=1,Name="t1"},
                new Teacher(){ Id=2,Name="t2"},
                new Teacher(){ Id=3,Name="t3"},
                new Teacher(){ Id=4,Name="t4"},
                new Teacher(){ Id=5,Name="t5"}
            };
            modelBuilder.Entity<Teacher>().HasData(teachers);

            var arrangeCourses = new List<ArrangeCourse>()
            {
                new ArrangeCourse(){Id=1,StudentId=students[0].Id,TeacherId=teachers[0].Id},
                new ArrangeCourse(){Id=2,StudentId=students[1].Id,TeacherId=teachers[0].Id},
                new ArrangeCourse(){Id=3,StudentId=students[2].Id,TeacherId=teachers[0].Id},
                new ArrangeCourse(){Id=4,StudentId=students[3].Id,TeacherId=teachers[1].Id},
                new ArrangeCourse(){Id=5,StudentId=students[4].Id,TeacherId=teachers[1].Id},
                new ArrangeCourse(){Id=6,StudentId=students[4].Id,TeacherId=teachers[1].Id},
                new ArrangeCourse(){Id=7,StudentId=students[1].Id,TeacherId=teachers[2].Id},
                new ArrangeCourse(){Id=8,StudentId=students[3].Id,TeacherId=teachers[2].Id},
                new ArrangeCourse(){Id=9,StudentId=students[4].Id,TeacherId=teachers[2].Id},
                new ArrangeCourse(){Id=10,StudentId=students[2].Id,TeacherId=teachers[3].Id},
                new ArrangeCourse(){Id=11,StudentId=students[3].Id,TeacherId=teachers[3].Id},
                new ArrangeCourse(){Id=12,StudentId=students[4].Id,TeacherId=teachers[3].Id},
                new ArrangeCourse(){Id=13,StudentId=students[0].Id,TeacherId=teachers[3].Id},
                new ArrangeCourse(){Id=14,StudentId=students[4].Id,TeacherId=teachers[4].Id}
            };
            modelBuilder.Entity<ArrangeCourse>().HasData(arrangeCourses);
        }
    }
}

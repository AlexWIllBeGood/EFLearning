using CodeFirst20190708.ModelConfigs;
using CodeFirst20190708.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst20190708
{
    public class LocalContext:DbContext
    {
        public LocalContext() : base("LocalDb")
        {
            Database.SetInitializer<LocalContext>(null);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ArrangeCourse> ArrangeCourses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfig());
            modelBuilder.Configurations.Add(new TeacherConfig());
            modelBuilder.Configurations.Add(new ArrangeCourseConfig());
        }

    }
}

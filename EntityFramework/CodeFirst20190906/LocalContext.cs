using CodeFirst20190906.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst20190906
{
    public class LocalContext:DbContext
    {
        public LocalContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Student> students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //var students = new List<Student>(){
            //    new Student() { Name="Alex"},
            //    new Student() { Name="Alin"},
            //};
            //modelBuilder.Entity<Student>().HasData(students);
        }
    }
}

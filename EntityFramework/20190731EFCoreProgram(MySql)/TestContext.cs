using _20190731EFCoreProgram_MySql_.ModelMaps;
using _20190731EFCoreProgram_MySql_.Models;
using _20190731EFCoreProgram_MySql_.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20190731EFCoreProgram_MySql_
{
    public class TestContext:DbContext
    {
        public TestContext(DbContextOptions<TestContext> options):base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseMySQL("");
        //}
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Student>(new StudentMap());
        }
    }
}

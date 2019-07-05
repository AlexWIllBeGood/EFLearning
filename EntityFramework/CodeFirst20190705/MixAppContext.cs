using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst20190705.Models;
using CodeFirst20190705.ModelConfiguration;

namespace CodeFirst20190705
{
    public class MixAppContext:DbContext
    {
        public MixAppContext(string connStr) : base(connStr)
        {

        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionSelection> QuestionSelections { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new QuestionConifg());
        }
    }
}

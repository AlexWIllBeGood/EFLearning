using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Context:DbContext
    {
        public Context() : base("name=LocalDatabase")
        { }
        public DbSet<Donator> donators { get; set; }
        public DbSet<PayWay> payways { get; set; }
    }
}

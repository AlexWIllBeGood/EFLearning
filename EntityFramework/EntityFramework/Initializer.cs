using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework
{
    class Initializer:DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            context.payways.AddRange(new List<PayWay>() {
                new PayWay(){ Name="支付宝"},
                new PayWay(){ Name="微信"},
                new PayWay(){ Name="QQ"},
            });
        }
    }
}

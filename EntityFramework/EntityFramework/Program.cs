using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用初始化器
            Database.SetInitializer(new Initializer());

            #region code创建数据库（假如不存在）
            //using (Context context = new Context())
            //{
            //    context.Database.CreateIfNotExists();
            //}
            //Console.WriteLine("DB has been created!");
            //Console.ReadLine();
            #endregion

            #region CRUD操作

            using (Context context = new Context())
            {
                context.Database.CreateIfNotExists();

                #region add
                //context.Database.ExecuteSqlCommand();
                //List<Donator> donators = new List<Donator>() {
                //        new Donator(){
                //            Name="Alex",
                //            Amount=12,
                //            DonateDate=new DateTime(2018,7,2)
                //        },
                //        new Donator(){
                //            Name="Jason",
                //            Amount=24,
                //            DonateDate=new DateTime(2018,7,1)
                //        },
                //        new Donator(){
                //            Name="Linux",
                //            Amount=12,
                //            DonateDate=new DateTime(2018,6,2)
                //        },
                //    };
                //context.donators.AddRange(donators);
                //context.SaveChanges();
                #endregion

                #region remove
                //context.Database.CreateIfNotExists();
                //var donator = context.donators.FirstOrDefault(e => e.Name == "黄大仙");
                //if (donator != null)
                //{
                //    context.donators.Remove(donator);
                //    //持久化数据到数据库
                //    context.SaveChanges();
                //}
                #endregion

                #region query
                //if (context.donators.Any())
                //{
                //    foreach (var d in context.donators)
                //    {
                //        Console.WriteLine("Name:{0}\t,Amount:{1}\t,DonateDate:{2}\t", d.Name, d.Amount, d.DonateDate);
                //    }
                //}
                //Console.ReadLine();
                #endregion

                #region update
                var donator = context.donators.Where(e => e.Name == "Alex").FirstOrDefault();
                if (donator != null)
                {
                    donator.Amount = 100;
                    context.SaveChanges();
                }
                #endregion
            }
            #endregion
        }
    }
}

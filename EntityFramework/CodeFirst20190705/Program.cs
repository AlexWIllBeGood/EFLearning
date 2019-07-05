using CodeFirst20190705.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst20190705
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db =new MixAppContext("MixAppContext"))
            {
                List<Question> quesList = new List<Question>() {
                    new Question(){
                        Head="Q1",
                        Content="老师上课准时不迟到。",
                        CreateTime=DateTime.Now,
                        Status=101
                    }
                };
                db.Questions.AddRange(quesList);
            }
            Console.ReadKey();
        }
    }
}

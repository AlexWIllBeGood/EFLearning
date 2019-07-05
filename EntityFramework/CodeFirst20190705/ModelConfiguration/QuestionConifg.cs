using CodeFirst20190705.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst20190705.ModelConfiguration
{
    public class QuestionConifg:EntityTypeConfiguration<Question>
    {
        public QuestionConifg()
        {
            //修改表的名称
            ToTable("Question");
            //设置自增长
            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            //Property(e => e.Head).HasMaxLength(200);
            Property(e => e.Content).HasMaxLength(1000);
        }
    }
}

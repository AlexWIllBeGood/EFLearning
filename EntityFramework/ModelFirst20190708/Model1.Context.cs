﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirst20190708
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuestionaireEntities : DbContext
    {
        public QuestionaireEntities()
            : base("name=QuestionaireEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Questionaire> Questionaire { get; set; }
        public DbSet<QuestionSelection> QuestionSelection { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionaireDetail> QuestionaireDetail { get; set; }
    }
}
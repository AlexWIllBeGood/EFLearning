namespace CodeFirst20190708.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArrangeCourse",
                c => new
                    {
                        ArrangeCourseId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArrangeCourseId)
                .ForeignKey("dbo.Student", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Teacher", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 1000),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArrangeCourse", "TeacherId", "dbo.Teacher");
            DropForeignKey("dbo.ArrangeCourse", "StudentId", "dbo.Student");
            DropIndex("dbo.ArrangeCourse", new[] { "TeacherId" });
            DropIndex("dbo.ArrangeCourse", new[] { "StudentId" });
            DropTable("dbo.Teacher");
            DropTable("dbo.Student");
            DropTable("dbo.ArrangeCourse");
        }
    }
}

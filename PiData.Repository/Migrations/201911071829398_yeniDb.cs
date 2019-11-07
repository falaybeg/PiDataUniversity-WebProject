namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yeniDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentCourses", new[] { "Student_Id" });
            DropColumn("dbo.StudentCourses", "Student_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentCourses", "Student_Id", c => c.Int());
            CreateIndex("dbo.StudentCourses", "Student_Id");
            AddForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students", "Id");
        }
    }
}

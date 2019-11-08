namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UniversityInfoes", "FacultyInfo_Id", c => c.Int());
            AddColumn("dbo.UniversityInfoes", "FacultyInfo_Id1", c => c.Int());
            CreateIndex("dbo.UniversityInfoes", "FacultyInfo_Id");
            CreateIndex("dbo.UniversityInfoes", "FacultyInfo_Id1");
            AddForeignKey("dbo.UniversityInfoes", "FacultyInfo_Id", "dbo.FacultyInfoes", "Id");
            AddForeignKey("dbo.UniversityInfoes", "FacultyInfo_Id1", "dbo.FacultyInfoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UniversityInfoes", "FacultyInfo_Id1", "dbo.FacultyInfoes");
            DropForeignKey("dbo.UniversityInfoes", "FacultyInfo_Id", "dbo.FacultyInfoes");
            DropIndex("dbo.UniversityInfoes", new[] { "FacultyInfo_Id1" });
            DropIndex("dbo.UniversityInfoes", new[] { "FacultyInfo_Id" });
            DropColumn("dbo.UniversityInfoes", "FacultyInfo_Id1");
            DropColumn("dbo.UniversityInfoes", "FacultyInfo_Id");
        }
    }
}

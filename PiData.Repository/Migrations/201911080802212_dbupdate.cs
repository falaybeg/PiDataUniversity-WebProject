namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FacultyInfoes", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.FacultyInfoes", "ApplicationUser_Id");
            AddForeignKey("dbo.FacultyInfoes", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FacultyInfoes", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.FacultyInfoes", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.FacultyInfoes", "ApplicationUser_Id");
        }
    }
}

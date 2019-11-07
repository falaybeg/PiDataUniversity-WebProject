namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class academiccalendar : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ApplicationUserrUniversityInfoes", newName: "UniversityInfoApplicationUserrs");
            DropForeignKey("dbo.AcademicCalendars", "UniversityInfoId", "dbo.UniversityInfoes");
            DropIndex("dbo.AcademicCalendars", new[] { "UniversityInfoId" });
            DropPrimaryKey("dbo.UniversityInfoApplicationUserrs");
            AddPrimaryKey("dbo.UniversityInfoApplicationUserrs", new[] { "UniversityInfo_Id", "ApplicationUserr_Id" });
            DropColumn("dbo.AcademicCalendars", "UniversityInfoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AcademicCalendars", "UniversityInfoId", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.UniversityInfoApplicationUserrs");
            AddPrimaryKey("dbo.UniversityInfoApplicationUserrs", new[] { "ApplicationUserr_Id", "UniversityInfo_Id" });
            CreateIndex("dbo.AcademicCalendars", "UniversityInfoId");
            AddForeignKey("dbo.AcademicCalendars", "UniversityInfoId", "dbo.UniversityInfoes", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.UniversityInfoApplicationUserrs", newName: "ApplicationUserrUniversityInfoes");
        }
    }
}

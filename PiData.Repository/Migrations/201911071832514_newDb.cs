namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FacultyInfoApplicationUserrs", "FacultyInfo_Id", "dbo.FacultyInfoes");
            DropForeignKey("dbo.FacultyInfoApplicationUserrs", "ApplicationUserr_Id", "dbo.AspNetUsers");
            DropIndex("dbo.FacultyInfoApplicationUserrs", new[] { "FacultyInfo_Id" });
            DropIndex("dbo.FacultyInfoApplicationUserrs", new[] { "ApplicationUserr_Id" });
            AddColumn("dbo.AspNetUsers", "FacultyInfo_Id", c => c.Int());
            AddColumn("dbo.FacultyInfoes", "ApplicationUserrId", c => c.String());
            CreateIndex("dbo.AspNetUsers", "FacultyInfo_Id");
            AddForeignKey("dbo.AspNetUsers", "FacultyInfo_Id", "dbo.FacultyInfoes", "Id");
            DropColumn("dbo.FacultyInfoes", "DeanId");
            DropTable("dbo.FacultyInfoApplicationUserrs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FacultyInfoApplicationUserrs",
                c => new
                    {
                        FacultyInfo_Id = c.Int(nullable: false),
                        ApplicationUserr_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FacultyInfo_Id, t.ApplicationUserr_Id });
            
            AddColumn("dbo.FacultyInfoes", "DeanId", c => c.String());
            DropForeignKey("dbo.AspNetUsers", "FacultyInfo_Id", "dbo.FacultyInfoes");
            DropIndex("dbo.AspNetUsers", new[] { "FacultyInfo_Id" });
            DropColumn("dbo.FacultyInfoes", "ApplicationUserrId");
            DropColumn("dbo.AspNetUsers", "FacultyInfo_Id");
            CreateIndex("dbo.FacultyInfoApplicationUserrs", "ApplicationUserr_Id");
            CreateIndex("dbo.FacultyInfoApplicationUserrs", "FacultyInfo_Id");
            AddForeignKey("dbo.FacultyInfoApplicationUserrs", "ApplicationUserr_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FacultyInfoApplicationUserrs", "FacultyInfo_Id", "dbo.FacultyInfoes", "Id", cascadeDelete: true);
        }
    }
}

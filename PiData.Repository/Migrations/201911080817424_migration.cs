namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FacultyInfoes", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "FacultyInfo_Id", "dbo.FacultyInfoes");
            DropIndex("dbo.AspNetUsers", new[] { "FacultyInfo_Id" });
            DropIndex("dbo.FacultyInfoes", new[] { "ApplicationUser_Id" });
            CreateTable(
                "dbo.FacultyInfoApplicationUserrs",
                c => new
                    {
                        FacultyInfo_Id = c.Int(nullable: false),
                        ApplicationUserr_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FacultyInfo_Id, t.ApplicationUserr_Id })
                .ForeignKey("dbo.FacultyInfoes", t => t.FacultyInfo_Id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserr_Id, cascadeDelete: true)
                .Index(t => t.FacultyInfo_Id)
                .Index(t => t.ApplicationUserr_Id);
            
            DropColumn("dbo.AspNetUsers", "FacultyInfo_Id");
            DropColumn("dbo.FacultyInfoes", "ApplicationUser_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FacultyInfoes", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "FacultyInfo_Id", c => c.Int());
            DropForeignKey("dbo.FacultyInfoApplicationUserrs", "ApplicationUserr_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.FacultyInfoApplicationUserrs", "FacultyInfo_Id", "dbo.FacultyInfoes");
            DropIndex("dbo.FacultyInfoApplicationUserrs", new[] { "ApplicationUserr_Id" });
            DropIndex("dbo.FacultyInfoApplicationUserrs", new[] { "FacultyInfo_Id" });
            DropTable("dbo.FacultyInfoApplicationUserrs");
            CreateIndex("dbo.FacultyInfoes", "ApplicationUser_Id");
            CreateIndex("dbo.AspNetUsers", "FacultyInfo_Id");
            AddForeignKey("dbo.AspNetUsers", "FacultyInfo_Id", "dbo.FacultyInfoes", "Id");
            AddForeignKey("dbo.FacultyInfoes", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}

namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databaupdatephasee : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DepartmentInfoes", "FacultyInfoId", "dbo.FacultyInfoes");
            AddColumn("dbo.DepartmentInfoes", "FacultyInfo_Id", c => c.Int());
            AddColumn("dbo.FacultyInfoes", "DepartmentInfo_Id", c => c.Int());
            CreateIndex("dbo.DepartmentInfoes", "FacultyInfo_Id");
            CreateIndex("dbo.FacultyInfoes", "DepartmentInfo_Id");
            AddForeignKey("dbo.FacultyInfoes", "DepartmentInfo_Id", "dbo.DepartmentInfoes", "Id");
            AddForeignKey("dbo.DepartmentInfoes", "FacultyInfo_Id", "dbo.FacultyInfoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DepartmentInfoes", "FacultyInfo_Id", "dbo.FacultyInfoes");
            DropForeignKey("dbo.FacultyInfoes", "DepartmentInfo_Id", "dbo.DepartmentInfoes");
            DropIndex("dbo.FacultyInfoes", new[] { "DepartmentInfo_Id" });
            DropIndex("dbo.DepartmentInfoes", new[] { "FacultyInfo_Id" });
            DropColumn("dbo.FacultyInfoes", "DepartmentInfo_Id");
            DropColumn("dbo.DepartmentInfoes", "FacultyInfo_Id");
            AddForeignKey("dbo.DepartmentInfoes", "FacultyInfoId", "dbo.FacultyInfoes", "Id", cascadeDelete: true);
        }
    }
}

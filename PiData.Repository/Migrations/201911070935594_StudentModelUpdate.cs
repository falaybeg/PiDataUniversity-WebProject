namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentModelUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "StartedTime", c => c.DateTime());
            AlterColumn("dbo.Teachers", "DepartmentId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teachers", "DepartmentId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "StartedTime", c => c.DateTime(nullable: false));
        }
    }
}

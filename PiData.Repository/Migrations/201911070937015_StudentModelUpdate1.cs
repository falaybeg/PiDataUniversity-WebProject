namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentModelUpdate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "DepartmentId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "DepartmentId", c => c.Int(nullable: false));
        }
    }
}

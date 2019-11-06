namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableRegistered : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "RegisteredDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "RegisteredDate", c => c.DateTime(nullable: false));
        }
    }
}

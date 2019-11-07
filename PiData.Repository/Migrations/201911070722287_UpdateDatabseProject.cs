namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabseProject : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UniversityInfoes", "RectorId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UniversityInfoes", "RectorId", c => c.Int(nullable: false));
        }
    }
}

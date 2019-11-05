namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AcademicCalendars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Info = c.String(),
                        InfoDate = c.DateTime(nullable: false),
                        UniversityId = c.Int(nullable: false),
                        UniversityInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UniversityInfoes", t => t.UniversityInfo_Id)
                .Index(t => t.UniversityInfo_Id);
            
            CreateTable(
                "dbo.UniversityInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RectorId = c.Int(nullable: false),
                        RectorMessage = c.String(),
                        Name = c.String(),
                        History = c.String(),
                        Mission = c.String(),
                        Vission = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        FaxNo = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UniversityAnnouncements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UniversityId = c.Int(nullable: false),
                        Tittle = c.String(),
                        Context = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        UniversityInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UniversityInfoes", t => t.UniversityInfo_Id)
                .Index(t => t.UniversityInfo_Id);
            
            CreateTable(
                "dbo.UniversityNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UniversityId = c.Int(nullable: false),
                        Tittle = c.String(),
                        Context = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        UniversityInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UniversityInfoes", t => t.UniversityInfo_Id)
                .Index(t => t.UniversityInfo_Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        AKTS = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        DepartmentInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmentInfoes", t => t.DepartmentInfo_Id)
                .Index(t => t.DepartmentInfo_Id);
            
            CreateTable(
                "dbo.DepartmentInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HeadOfDepartmentId = c.Int(nullable: false),
                        HeadDepartmentMessage = c.String(),
                        FacultyId = c.Int(nullable: false),
                        Name = c.String(),
                        History = c.String(),
                        Mission = c.String(),
                        Vission = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        FaxNo = c.String(),
                        Email = c.String(),
                        FacultyInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FacultyInfoes", t => t.FacultyInfo_Id)
                .Index(t => t.FacultyInfo_Id);
            
            CreateTable(
                "dbo.DepartmentAnnouncements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        Tittle = c.String(),
                        Context = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        DepartmentInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmentInfoes", t => t.DepartmentInfo_Id)
                .Index(t => t.DepartmentInfo_Id);
            
            CreateTable(
                "dbo.DepartmentNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        Tittle = c.String(),
                        Context = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        DepartmentInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmentInfoes", t => t.DepartmentInfo_Id)
                .Index(t => t.DepartmentInfo_Id);
            
            CreateTable(
                "dbo.FacultyInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeanId = c.Int(nullable: false),
                        DeanMessage = c.String(),
                        UniversityId = c.Int(nullable: false),
                        Name = c.String(),
                        History = c.String(),
                        Mission = c.String(),
                        Vission = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        FaxNo = c.String(),
                        Email = c.String(),
                        UniversityInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UniversityInfoes", t => t.UniversityInfo_Id)
                .Index(t => t.UniversityInfo_Id);
            
            CreateTable(
                "dbo.FacultyAnnouncements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacultyId = c.Int(nullable: false),
                        Tittle = c.String(),
                        Context = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        FacultyInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FacultyInfoes", t => t.FacultyInfo_Id)
                .Index(t => t.FacultyInfo_Id);
            
            CreateTable(
                "dbo.FacultyNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacultyId = c.Int(nullable: false),
                        Tittle = c.String(),
                        Context = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        FacultyInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FacultyInfoes", t => t.FacultyInfo_Id)
                .Index(t => t.FacultyInfo_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        StudentNumber = c.String(),
                        StartedTime = c.DateTime(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        ApplicationUserr_Id = c.String(maxLength: 128),
                        DepartmentInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserr_Id)
                .ForeignKey("dbo.DepartmentInfoes", t => t.DepartmentInfo_Id)
                .Index(t => t.ApplicationUserr_Id)
                .Index(t => t.DepartmentInfo_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IdentityNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        RegisteredDate = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        Title = c.String(),
                        ApplicationUserr_Id = c.String(maxLength: 128),
                        DepartmentInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserr_Id)
                .ForeignKey("dbo.DepartmentInfoes", t => t.DepartmentInfo_Id)
                .Index(t => t.ApplicationUserr_Id)
                .Index(t => t.DepartmentInfo_Id);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        MidTermPoint = c.Int(nullable: false),
                        FinalPoint = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.StudentCourses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Students", "DepartmentInfo_Id", "dbo.DepartmentInfoes");
            DropForeignKey("dbo.Teachers", "DepartmentInfo_Id", "dbo.DepartmentInfoes");
            DropForeignKey("dbo.Teachers", "ApplicationUserr_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Students", "ApplicationUserr_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.FacultyInfoes", "UniversityInfo_Id", "dbo.UniversityInfoes");
            DropForeignKey("dbo.FacultyNews", "FacultyInfo_Id", "dbo.FacultyInfoes");
            DropForeignKey("dbo.FacultyAnnouncements", "FacultyInfo_Id", "dbo.FacultyInfoes");
            DropForeignKey("dbo.DepartmentInfoes", "FacultyInfo_Id", "dbo.FacultyInfoes");
            DropForeignKey("dbo.DepartmentNews", "DepartmentInfo_Id", "dbo.DepartmentInfoes");
            DropForeignKey("dbo.DepartmentAnnouncements", "DepartmentInfo_Id", "dbo.DepartmentInfoes");
            DropForeignKey("dbo.Courses", "DepartmentInfo_Id", "dbo.DepartmentInfoes");
            DropForeignKey("dbo.AcademicCalendars", "UniversityInfo_Id", "dbo.UniversityInfoes");
            DropForeignKey("dbo.UniversityNews", "UniversityInfo_Id", "dbo.UniversityInfoes");
            DropForeignKey("dbo.UniversityAnnouncements", "UniversityInfo_Id", "dbo.UniversityInfoes");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.StudentCourses", new[] { "CourseId" });
            DropIndex("dbo.StudentCourses", new[] { "StudentId" });
            DropIndex("dbo.Teachers", new[] { "DepartmentInfo_Id" });
            DropIndex("dbo.Teachers", new[] { "ApplicationUserr_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Students", new[] { "DepartmentInfo_Id" });
            DropIndex("dbo.Students", new[] { "ApplicationUserr_Id" });
            DropIndex("dbo.FacultyNews", new[] { "FacultyInfo_Id" });
            DropIndex("dbo.FacultyAnnouncements", new[] { "FacultyInfo_Id" });
            DropIndex("dbo.FacultyInfoes", new[] { "UniversityInfo_Id" });
            DropIndex("dbo.DepartmentNews", new[] { "DepartmentInfo_Id" });
            DropIndex("dbo.DepartmentAnnouncements", new[] { "DepartmentInfo_Id" });
            DropIndex("dbo.DepartmentInfoes", new[] { "FacultyInfo_Id" });
            DropIndex("dbo.Courses", new[] { "DepartmentInfo_Id" });
            DropIndex("dbo.UniversityNews", new[] { "UniversityInfo_Id" });
            DropIndex("dbo.UniversityAnnouncements", new[] { "UniversityInfo_Id" });
            DropIndex("dbo.AcademicCalendars", new[] { "UniversityInfo_Id" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Teachers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Students");
            DropTable("dbo.FacultyNews");
            DropTable("dbo.FacultyAnnouncements");
            DropTable("dbo.FacultyInfoes");
            DropTable("dbo.DepartmentNews");
            DropTable("dbo.DepartmentAnnouncements");
            DropTable("dbo.DepartmentInfoes");
            DropTable("dbo.Courses");
            DropTable("dbo.UniversityNews");
            DropTable("dbo.UniversityAnnouncements");
            DropTable("dbo.UniversityInfoes");
            DropTable("dbo.AcademicCalendars");
        }
    }
}

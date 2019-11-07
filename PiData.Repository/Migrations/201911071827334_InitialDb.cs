namespace NtierApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
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
                        UniversityInfoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UniversityInfoes", t => t.UniversityInfoId, cascadeDelete: true)
                .Index(t => t.UniversityInfoId);
            
            CreateTable(
                "dbo.UniversityInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserrId = c.String(),
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
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IdentityNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        RegisteredDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        BirthDay = c.DateTime(precision: 7, storeType: "datetime2"),
                        StudentNumber = c.String(),
                        StartedTime = c.DateTime(),
                        DepartmentInfoId = c.Int(),
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
                "dbo.DepartmentInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HeadOfDepartmentId = c.String(),
                        HeadDepartmentMessage = c.String(),
                        FacultyInfoId = c.Int(nullable: false),
                        ApplicationUserrId = c.String(maxLength: 128),
                        Name = c.String(),
                        History = c.String(),
                        Mission = c.String(),
                        Vission = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        FaxNo = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserrId)
                .ForeignKey("dbo.FacultyInfoes", t => t.FacultyInfoId, cascadeDelete: true)
                .Index(t => t.FacultyInfoId)
                .Index(t => t.ApplicationUserrId);
            
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
                        DepartmentInfoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmentInfoes", t => t.DepartmentInfoId, cascadeDelete: true)
                .Index(t => t.DepartmentInfoId);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserrId = c.String(maxLength: 128),
                        CourseId = c.Int(nullable: false),
                        MidTermPoint = c.Int(nullable: false),
                        FinalPoint = c.Int(nullable: false),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserrId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.ApplicationUserrId)
                .Index(t => t.CourseId)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        StudentNumber = c.String(),
                        StartedTime = c.DateTime(),
                        DepartmentId = c.Int(),
                        ApplicationUserr_Id = c.String(maxLength: 128),
                        DepartmentInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserr_Id)
                .ForeignKey("dbo.DepartmentInfoes", t => t.DepartmentInfo_Id)
                .Index(t => t.ApplicationUserr_Id)
                .Index(t => t.DepartmentInfo_Id);
            
            CreateTable(
                "dbo.DepartmentAnnouncements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentInfoId = c.Int(nullable: false),
                        Tittle = c.String(),
                        Context = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmentInfoes", t => t.DepartmentInfoId, cascadeDelete: true)
                .Index(t => t.DepartmentInfoId);
            
            CreateTable(
                "dbo.DepartmentNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentInfoId = c.Int(nullable: false),
                        Tittle = c.String(),
                        Context = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmentInfoes", t => t.DepartmentInfoId, cascadeDelete: true)
                .Index(t => t.DepartmentInfoId);
            
            CreateTable(
                "dbo.FacultyInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeanId = c.String(),
                        DeanMessage = c.String(),
                        UniversityInfoId = c.Int(nullable: false),
                        Name = c.String(),
                        History = c.String(),
                        Mission = c.String(),
                        Vission = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        FaxNo = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UniversityInfoes", t => t.UniversityInfoId, cascadeDelete: true)
                .Index(t => t.UniversityInfoId);
            
            CreateTable(
                "dbo.FacultyAnnouncements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacultyInfoId = c.Int(nullable: false),
                        Tittle = c.String(),
                        Context = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FacultyInfoes", t => t.FacultyInfoId, cascadeDelete: true)
                .Index(t => t.FacultyInfoId);
            
            CreateTable(
                "dbo.FacultyNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacultyInfoId = c.Int(nullable: false),
                        Tittle = c.String(),
                        Context = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FacultyInfoes", t => t.FacultyInfoId, cascadeDelete: true)
                .Index(t => t.FacultyInfoId);
            
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
                "dbo.UniversityAnnouncements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UniversityInfoId = c.Int(nullable: false),
                        Tittle = c.String(),
                        Context = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UniversityInfoes", t => t.UniversityInfoId, cascadeDelete: true)
                .Index(t => t.UniversityInfoId);
            
            CreateTable(
                "dbo.UniversityNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UniversityInfoId = c.Int(nullable: false),
                        Tittle = c.String(),
                        Context = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UniversityInfoes", t => t.UniversityInfoId, cascadeDelete: true)
                .Index(t => t.UniversityInfoId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        DepartmentId = c.Int(),
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
            
            CreateTable(
                "dbo.ApplicationUserrUniversityInfoes",
                c => new
                    {
                        ApplicationUserr_Id = c.String(nullable: false, maxLength: 128),
                        UniversityInfo_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ApplicationUserr_Id, t.UniversityInfo_Id })
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserr_Id, cascadeDelete: true)
                .ForeignKey("dbo.UniversityInfoes", t => t.UniversityInfo_Id, cascadeDelete: true)
                .Index(t => t.ApplicationUserr_Id)
                .Index(t => t.UniversityInfo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "DepartmentInfo_Id", "dbo.DepartmentInfoes");
            DropForeignKey("dbo.Teachers", "ApplicationUserr_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AcademicCalendars", "UniversityInfoId", "dbo.UniversityInfoes");
            DropForeignKey("dbo.UniversityNews", "UniversityInfoId", "dbo.UniversityInfoes");
            DropForeignKey("dbo.UniversityAnnouncements", "UniversityInfoId", "dbo.UniversityInfoes");
            DropForeignKey("dbo.ApplicationUserrUniversityInfoes", "UniversityInfo_Id", "dbo.UniversityInfoes");
            DropForeignKey("dbo.ApplicationUserrUniversityInfoes", "ApplicationUserr_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.FacultyInfoes", "UniversityInfoId", "dbo.UniversityInfoes");
            DropForeignKey("dbo.FacultyNews", "FacultyInfoId", "dbo.FacultyInfoes");
            DropForeignKey("dbo.FacultyAnnouncements", "FacultyInfoId", "dbo.FacultyInfoes");
            DropForeignKey("dbo.DepartmentInfoes", "FacultyInfoId", "dbo.FacultyInfoes");
            DropForeignKey("dbo.FacultyInfoApplicationUserrs", "ApplicationUserr_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.FacultyInfoApplicationUserrs", "FacultyInfo_Id", "dbo.FacultyInfoes");
            DropForeignKey("dbo.DepartmentNews", "DepartmentInfoId", "dbo.DepartmentInfoes");
            DropForeignKey("dbo.DepartmentAnnouncements", "DepartmentInfoId", "dbo.DepartmentInfoes");
            DropForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Students", "DepartmentInfo_Id", "dbo.DepartmentInfoes");
            DropForeignKey("dbo.Students", "ApplicationUserr_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "ApplicationUserrId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "DepartmentInfoId", "dbo.DepartmentInfoes");
            DropForeignKey("dbo.DepartmentInfoes", "ApplicationUserrId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.ApplicationUserrUniversityInfoes", new[] { "UniversityInfo_Id" });
            DropIndex("dbo.ApplicationUserrUniversityInfoes", new[] { "ApplicationUserr_Id" });
            DropIndex("dbo.FacultyInfoApplicationUserrs", new[] { "ApplicationUserr_Id" });
            DropIndex("dbo.FacultyInfoApplicationUserrs", new[] { "FacultyInfo_Id" });
            DropIndex("dbo.Teachers", new[] { "DepartmentInfo_Id" });
            DropIndex("dbo.Teachers", new[] { "ApplicationUserr_Id" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.UniversityNews", new[] { "UniversityInfoId" });
            DropIndex("dbo.UniversityAnnouncements", new[] { "UniversityInfoId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.FacultyNews", new[] { "FacultyInfoId" });
            DropIndex("dbo.FacultyAnnouncements", new[] { "FacultyInfoId" });
            DropIndex("dbo.FacultyInfoes", new[] { "UniversityInfoId" });
            DropIndex("dbo.DepartmentNews", new[] { "DepartmentInfoId" });
            DropIndex("dbo.DepartmentAnnouncements", new[] { "DepartmentInfoId" });
            DropIndex("dbo.Students", new[] { "DepartmentInfo_Id" });
            DropIndex("dbo.Students", new[] { "ApplicationUserr_Id" });
            DropIndex("dbo.StudentCourses", new[] { "Student_Id" });
            DropIndex("dbo.StudentCourses", new[] { "CourseId" });
            DropIndex("dbo.StudentCourses", new[] { "ApplicationUserrId" });
            DropIndex("dbo.Courses", new[] { "DepartmentInfoId" });
            DropIndex("dbo.DepartmentInfoes", new[] { "ApplicationUserrId" });
            DropIndex("dbo.DepartmentInfoes", new[] { "FacultyInfoId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AcademicCalendars", new[] { "UniversityInfoId" });
            DropTable("dbo.ApplicationUserrUniversityInfoes");
            DropTable("dbo.FacultyInfoApplicationUserrs");
            DropTable("dbo.Teachers");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.UniversityNews");
            DropTable("dbo.UniversityAnnouncements");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.FacultyNews");
            DropTable("dbo.FacultyAnnouncements");
            DropTable("dbo.FacultyInfoes");
            DropTable("dbo.DepartmentNews");
            DropTable("dbo.DepartmentAnnouncements");
            DropTable("dbo.Students");
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Courses");
            DropTable("dbo.DepartmentInfoes");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.UniversityInfoes");
            DropTable("dbo.AcademicCalendars");
        }
    }
}

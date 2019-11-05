using Microsoft.AspNet.Identity.EntityFramework;
using NTier.Domain.Model;
using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace PiDataApp.Repository.Context
{
    public class PiDataDbContext : IdentityDbContext<ApplicationUserr>
    {

        public PiDataDbContext()
                : base("PiDataDbContext")
        {
        }

        public virtual DbSet<AcademicCalendar> AcademicCalendar { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<DepartmentAnnouncement> DepartmentAnnouncement { get; set; }
        public virtual DbSet<DepartmentInfo> DepartmentInfo { get; set; }
        public virtual DbSet<DepartmentNews> DepartmentNews { get; set; }
        public virtual DbSet<FacultyAnnouncement> FacultyAnnouncement { get; set; }
        public virtual DbSet<FacultyInfo> FacultyInfo { get; set; }
        public virtual DbSet<FacultyNews> FacultyNews { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentCourse> StudentCourse { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<UniversityAnnouncement> UniversityAnnouncement { get; set; }
        public virtual DbSet<UniversityInfo> UniversityInfo { get; set; }
        public virtual DbSet<UniversityNews> UniversityNews { get; set; }
    }
}

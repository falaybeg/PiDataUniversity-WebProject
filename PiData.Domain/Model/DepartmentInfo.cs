using NTier.Domain.Model;
using PiData.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.Domain.Model
{
    public class DepartmentInfo : InfoAbstract
    {
        public int HeadOfDepartmentId { get; set; }
        public string HeadDepartmentMessage { get; set; }
        public int FacultyId { get; set; }

        public virtual ICollection<Teacher> Teacher { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<Course> Course { get; set; }
        public virtual ICollection<DepartmentNews> DepartmentNews { get; set; }
        public virtual ICollection<DepartmentAnnouncement> DepartmentAnnouncement { get; set; }
        public virtual FacultyInfo FacultyInfo { get; set; }

    }
}

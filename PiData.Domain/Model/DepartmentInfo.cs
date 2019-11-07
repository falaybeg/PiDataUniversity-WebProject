using PiData.Domain.Model;
using PiData.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PiData.Domain.Model
{
    public class DepartmentInfo : InfoAbstract
    {

        public string HeadOfDepartmentId { get; set; }
        public string HeadDepartmentMessage { get; set; }
        public int FacultyInfoId { get; set; }
        public string ApplicationUserrId { get; set; }


        public virtual ApplicationUserr ApplicationUserr { get; set; }
        public virtual ICollection<Course> Course { get; set; }
        public virtual ICollection<DepartmentNews> DepartmentNews { get; set; }
        public virtual ICollection<DepartmentAnnouncement> DepartmentAnnouncement { get; set; }
        public virtual FacultyInfo FacultyInfo { get; set; }

    }
}

using PiData.Domain.Model;
using PiData.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.Domain.Model
{
    public class FacultyInfo : InfoAbstract
    {
        public string ApplicationUserrId { get; set; }
        public string DeanMessage { get; set; }
        public int UniversityInfoId { get; set; }

        public virtual ICollection<ApplicationUserr> ApplicationUserr { get; set; }
        public virtual ICollection<DepartmentInfo> DepartmentInfo { get; set; }
        public virtual ICollection<FacultyNews> FacultyNews { get; set; }
        public virtual ICollection<FacultyAnnouncement> FacultyAnnouncement { get; set; }
        public virtual ICollection<UniversityInfo> UniversityInfoo { get; set; }
        public virtual UniversityInfo UniversityInfo { get; set; }


    }
}

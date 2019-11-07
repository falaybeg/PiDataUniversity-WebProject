using PiData.Domain.Model;
using PiData.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.Domain.Model
{
    public class UniversityInfo : InfoAbstract
    {
        public string ApplicationUserrId { get; set; }
        public string RectorMessage { get; set; }



        public virtual ICollection<ApplicationUserr> ApplicationUserr { get; set; }
        public virtual ICollection<UniversityNews> UniversityNews { get; set; }
        public virtual ICollection<UniversityAnnouncement> UniversityAnnouncement { get; set; }


    }
}

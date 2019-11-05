using PiData.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PiData.Domain.Model;

namespace PiData.Domain.Model
{
    public class UniversityAnnouncement : Announcement
    {
        public int UniversityId { get; set; }

        public virtual UniversityInfo UniversityInfo { get; set; }
    }
}

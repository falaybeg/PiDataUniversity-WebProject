using PiData.Domain.Abstract;
using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.Domain.Model
{
    public class FacultyAnnouncement : Announcement
    {
        public int FacultyInfoId { get; set; }

        public virtual FacultyInfo FacultyInfo { get; set; }
    }
}

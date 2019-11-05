using NTier.Domain.Abstract;
using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Domain.Model
{
    public class FacultyAnnouncement : Announcement
    {
        public int FacultyId { get; set; }

        public virtual FacultyInfo FacultyInfo { get; set; }
    }
}

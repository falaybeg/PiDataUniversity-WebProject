using NTier.Domain.Abstract;
using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Domain.Model
{
    public class DepartmentAnnouncement: Announcement
    {
        public int DepartmentId { get; set; }

        public virtual DepartmentInfo DepartmentInfo { get; set; }
    }
}

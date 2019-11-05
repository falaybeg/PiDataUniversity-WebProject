using NTier.Domain.Abstract;
using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Domain.Model
{
    public class UniversityNews : News
    {

        public int UniversityId { get; set; }

        public virtual UniversityInfo UniversityInfo { get; set; }
    }
}

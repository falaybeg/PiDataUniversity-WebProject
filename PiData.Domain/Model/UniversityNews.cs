using PiData.Domain.Abstract;
using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.Domain.Model
{
    public class UniversityNews : News
    {

        public int UniversityInfoId { get; set; }

        public virtual UniversityInfo UniversityInfo { get; set; }
    }
}

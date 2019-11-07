using PiData.Domain.Abstract;
using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.Domain.Model
{
    public class DepartmentNews : News
    {
        public int DepartmentInfoId { get; set; }

        public virtual DepartmentInfo DepartmentInfo { get; set; }

    }
}

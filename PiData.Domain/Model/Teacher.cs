using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.Domain.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string Title { get; set; }

        public virtual DepartmentInfo DepartmentInfo { get; set; }
        public virtual ApplicationUserr ApplicationUserr { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.Domain.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string StudentNumber { get; set; }
        public DateTime StartedTime { get; set; }
        public int DepartmentId { get; set; }

        public virtual DepartmentInfo DepartmentInfo { get; set; }
        public virtual ApplicationUserr ApplicationUserr { get; set; }

    }
}

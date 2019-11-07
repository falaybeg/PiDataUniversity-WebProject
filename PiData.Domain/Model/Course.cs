using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.Domain.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AKTS { get; set; }
        public DateTime CreatedTime { get; set; }
        public int DepartmentInfoId { get; set; }

        public virtual DepartmentInfo DepartmentInfo { get; set; }
        public virtual ICollection<StudentCourse> StudentCourse { get; set; }

    }
}

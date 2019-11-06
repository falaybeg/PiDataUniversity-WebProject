using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiDataWebApp.Models
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AKTS { get; set; }
        public DateTime CreatedTime { get; set; }
        public int DepartmentId { get; set; }

        public  DepartmentInfo DepartmentInfo { get; set; }
        public  StudentCourse StudentCourse { get; set; }

    }
}
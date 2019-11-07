using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiDataWebApp.Models
{
    public class DepartmentInfoViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string History { get; set; }
        public string Mission { get; set; }
        public string Vission { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }

        public string HeadOfDepartmentId { get; set; }
        public string HeadDepartmentMessage { get; set; }
        public int FacultyId { get; set; }


        public DepartmentNews DepartmentNews { get; set; }
        public DepartmentAnnouncement DepartmentAnnouncement { get; set; }
    }
}
using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiDataWebApp.Models
{
    public class UniversityInfoViewModel
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
        public int RectorId { get; set; }
        public string RectorMessage { get; set; }

        public  UniversityNews UniversityNews { get; set; }
        public  UniversityAnnouncement UniversityAnnouncement { get; set; }
    }
}
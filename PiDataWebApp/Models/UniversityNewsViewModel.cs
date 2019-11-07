using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiDataWebApp.Models
{
    public class UniversityNewsViewModel
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Context { get; set; }
        public DateTime CreatedTime { get; set; }
        public int UniversityInfoId { get; set; }

        public UniversityInfo UniversityInfo { get; set; }
    }
}
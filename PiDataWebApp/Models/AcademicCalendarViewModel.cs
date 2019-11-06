using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiDataWebApp.Models
{
    public class AcademicCalendarViewModel
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public DateTime InfoDate { get; set; }

    }
}
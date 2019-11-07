using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiDataWebApp.Models
{
    public class StudentViewModel : RegisterBindingModel
    {

        public string StudentNumber { get; set; }
        public DateTime StartedTime { get; set; }
        public int DepartmentId { get; set; }
    }
}
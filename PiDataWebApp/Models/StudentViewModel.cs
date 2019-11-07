using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiDataWebApp.Models
{
    public class StudentViewModel : RegisterBindingModel
    {
        public string Id { get; set; }
        public string StudentNumber { get; set; }
        public Nullable<DateTime> StartedTime { get; set; }
        public int DepartmentInfoId { get; set; }
        public DepartmentInfo DepartmentInfo { get; set; }
    }
}
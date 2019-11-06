using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Areas.Admin.Controllers
{
    public class CourseController : Controller
    {
        // GET: Admin/Course
        public ActionResult AddCourse()
        {
            return View();
        }
        public ActionResult ListCourse()
        {
            return View();
        }
    }
}
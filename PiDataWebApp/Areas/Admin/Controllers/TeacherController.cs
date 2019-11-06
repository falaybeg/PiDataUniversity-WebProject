using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Areas.Admin.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Admin/Teacher
        public ActionResult AddTeacher()
        {
            return View();
        }
        public ActionResult ListTeacher()
        {
            return View();
        }
        public ActionResult EditTeacher(int id)
        {
            return View();
        }
    }
}
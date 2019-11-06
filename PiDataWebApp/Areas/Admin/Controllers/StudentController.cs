using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        // GET: Admin/Student
        public ActionResult AddStudent()
        {
            return View();
        }
        public ActionResult ListStudent()
        {
            return View();
        }
        public ActionResult EditStudent(int id)
        {
            return View();
        }

        public ActionResult ListStudentPoint()
        {
            return View();
        }
    }
}
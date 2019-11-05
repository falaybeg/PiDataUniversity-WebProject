using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataApp.Areas.Admin.Controllers
{
    public class UniversityInfoController : Controller
    {
        // GET: Admin/UniversityInfo
        public ActionResult AddUniversityInfo()
        {
            return View();
        }

        public ActionResult ListUniversityInfo()
        {
            return View();
        }

        public ActionResult AcademicCalendar()
        {
            return View();
        }
    }
}
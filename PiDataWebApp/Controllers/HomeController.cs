using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RectorMessage()
        {

            return View();
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult MissionVision()
        {
            return View();
        }

        public ActionResult AdministrativeUnits()
        {
            return View();
        }

        public ActionResult AcademicCalendar()
        {
            return View();
        }

        public ActionResult Faculties()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

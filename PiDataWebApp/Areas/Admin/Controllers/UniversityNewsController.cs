using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Areas.Admin.Controllers
{
    public class UniversityNewsController : Controller
    {
        // GET: Admin/UniversityNews
        public ActionResult AddNews()
        {
            return View();
        }

        public ActionResult ListNews()
        {
            return View();
        }

        public ActionResult EditNews(int id)
        {
            return View();
        }
    }
}
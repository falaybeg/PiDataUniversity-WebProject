using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Areas.Admin.Controllers
{
    public class UniversityAnnouncementController : Controller
    {
        // GET: Admin/UniversityAnnouncement
        public ActionResult AddAnnouncement()
        {
            return View();
        }
        public ActionResult ListAnnouncement()
        {
            return View();
        }

    }
}
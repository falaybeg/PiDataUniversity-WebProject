using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Areas.Admin.Controllers
{
    public class DepartmentInfoController : Controller
    {
        public ActionResult AddDepartmentInfo()
        {
            return View();
        }

        public ActionResult ListDepartmentInfo()
        {
            return View();
        }
    }
}
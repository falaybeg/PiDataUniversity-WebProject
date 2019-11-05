using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataApp.Areas.Admin.Controllers
{
    public class RoleManagementController : Controller
    {
        // GET: Admin/RoleManagement
        public ActionResult ListRole()
        {
            return View();
        }

        public ActionResult EditRole(int id)
        {
            return View();
        }
    }
}
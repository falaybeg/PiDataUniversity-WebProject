using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using PiDataApp.Repository.Context;
using PiDataWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {

        PiDataDbContext db;
        private ApplicationUserManager _userManager;
        RoleStore<IdentityRole> roleStore = null;
        RoleManager<IdentityRole> roleManager;



        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public StudentController()
        {
            db = new PiDataDbContext();
        }

        public ActionResult AddStudent()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "Erken", Value = "Erken" });
            items.Add(new SelectListItem { Text = "Kadın", Value = "Kadın" });

            ViewBag.Gender = items;

            return View();
        }
        public ActionResult ListStudent()
        {
            List<StudentViewModel> model = new List<StudentViewModel>();
            var resu = db.Users.ToList();
            foreach (var item in resu)
            {
                model.Add(new StudentViewModel
                {
                    IdentityNumber = item.IdentityNumber,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    StudentNumber = item.StudentNumber,
                    BirthDay = item.BirthDay,
                    Email = item.Email
                });
            }


            return View(model);
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
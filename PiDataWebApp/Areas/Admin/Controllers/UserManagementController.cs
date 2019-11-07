using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using PiDataApp;
using PiDataApp.Repository.Context;
using PiDataWebApp;
using PiDataWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Areas.Admin.Controllers
{
    public class UserManagementController : Controller
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

        public UserManagementController()
        {
            db = new PiDataDbContext();

        }

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult MyAccount()
        {
            return View();
        }

        public ActionResult UserList()
        {
            List<StudentViewModel> model = new List<StudentViewModel>();
            var resu = db.Users.ToList();

            foreach(var item in resu)
            {
                model.Add(new StudentViewModel
                {
                    Id = item.Id,
                    IdentityNumber = item.IdentityNumber,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Gender = item.Gender,
                    PhoneNumber = item.PhoneNumber,
                    StudentNumber = item.StudentNumber,
                    BirthDay = item.BirthDay,
                    Email = item.Email
                });
            }


            return View(model);
        }


        public ActionResult EditUser()
        {


            return View("EditUser");
        }

        public ActionResult AddStudent()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "Erken", Value = "Erken" });
            items.Add(new SelectListItem { Text = "Kadın", Value = "Kadın" });

            ViewBag.Gender = items;

            return View();
        }

        public ActionResult EditStudent(string id)
        {
            if (id != null)
            {
                var result = UserManager.FindByIdAsync(id);
                var user = result.Result;
                if (user != null)
                {
                    var vm = new StudentViewModel
                    {
                        Id = user.Id,
                        IdentityNumber = user.IdentityNumber,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Gender = user.Gender,
                        PhoneNumber = user.PhoneNumber,
                        StudentNumber = user.StudentNumber,
                        BirthDay = user.BirthDay,
                        Email = user.Email

                    };

                    List<SelectListItem> items = new List<SelectListItem>();
                    items.Add(new SelectListItem { Text = "Erken", Value = "Erken" });
                    items.Add(new SelectListItem { Text = "Kadın", Value = "Kadın" });

                    ViewBag.Gender = items;

                    return View("AddStudent", vm);
                }
                
            }
            return View("AddStudent");

        }



    }
}
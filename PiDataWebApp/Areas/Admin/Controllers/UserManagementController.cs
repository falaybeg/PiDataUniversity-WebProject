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


        public ActionResult EditUser()
        {
            roleStore = new RoleStore<IdentityRole>(new PiDataDbContext()); ;
            roleManager = new RoleManager<IdentityRole>(roleStore);

            var roles = roleManager.Roles.ToList();
            ViewBag.Roles = new SelectList(roles, "Name", "Name");

            //List<SelectListItem> items = new List<SelectListItem>();
            //foreach(var item in roles)
            //{
            //    items.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            //}


            return View("EditUser");
        }

        [Authorize]
        public ActionResult UpdateUser(string id)
        {
            /*
            roleStore = new RoleStore<IdentityRole>(new PiDataDbContext()); ;
            roleManager = new RoleManager<IdentityRole>(roleStore);
            //var resul = await UserManager.AddToRoleAsync("88b3e953-471f-43e0-89d1-23fde676b466","DepoMuduru");
            if (id != null)
            {
                var result = UserManager.FindByIdAsync(id);
                var user = result.Result;
                if (user != null)
                {
                    var roleName = UserManager.GetRoles(id);
                    var vm = new UserManagementViewModel
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        PhoneNumber = user.PhoneNumber,
                        Email = user.Email,
                        RegisteredDate = user.RegisteredDate,
                        RoleName = roleName[0]
                    };

                    var roles = roleManager.Roles.ToList();
                    //ViewData["Roles"] = new SelectList(roles, null, "Name");
                    ViewBag.Roles = new SelectList(roles, "Name", "Name");

                    return View("EditUser", vm);
                }
                
            }
            */
            return View("EditUser");

        }



    }
}
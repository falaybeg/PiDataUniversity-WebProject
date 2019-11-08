using Microsoft.AspNet.Identity.Owin;
using PiData.BLL.Interface;
using PiDataApp.Repository.Context;
using PiDataWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Areas.Admin.Controllers
{
    public class DepartmentInfoController : Controller
    {
        PiDataDbContext db;
        private ApplicationUserManager _userManager;
        private IDepartmentInfoBusiness _departmenInfo;
        private IUniversityInfoBusiness _universityBusiness;
        private IFacultyInfoBusiness _facultyInfo;

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
        public DepartmentInfoController()
        {
        }
        public DepartmentInfoController(IDepartmentInfoBusiness facultyInfo, IFacultyInfoBusiness universityInfo)
        {

            db = new PiDataDbContext();
            this._departmenInfo = facultyInfo;
            this._facultyInfo = universityInfo;
        }


        public ActionResult AddDepartmentInfo()
        {
            var result = (from user in db.Users
                          select new UserViewModel()
                          {
                              Id = user.Id,
                              FirstName = user.FirstName,
                              LastName = user.LastName,
                              RectorNameSurname = user.FirstName + " " + user.LastName
                          }).ToList();
            ViewBag.HeadOfDepart = new SelectList(result, "Id", "RectorNameSurname");

            var facultuy = _facultyInfo.GetAll().ToList();
            ViewBag.Faculty = new SelectList(facultuy, "Id", "Name");


            return View();
        }

        public ActionResult ListDepartmentInfo()
        {
            var result = _departmenInfo.GetAll().Select(x => new DepartmentInfoViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                Phone = x.Phone,
                FaxNo = x.FaxNo,
                Email = x.Email,
                FacultyInfo = x.FacultyInfo
            });

            return View(result);
        }
    }
}
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
    public class FacultyInfoController : Controller
    {
        PiDataDbContext db;
        private ApplicationUserManager _userManager;
        private IFacultyInfoBusiness _facultyInfo;
        private IUniversityInfoBusiness _universityBusiness;

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
        public FacultyInfoController()
        {
        }
        public FacultyInfoController(IFacultyInfoBusiness facultyInfo, IUniversityInfoBusiness universityInfo)
        {
          
            db = new PiDataDbContext();
            this._facultyInfo = facultyInfo;
            this._universityBusiness = universityInfo;
        }

        public ActionResult AddFacultyInfo()
        {
            var result = (from user in db.Users
                          select new UserViewModel()
                          {
                              Id = user.Id,
                              FirstName = user.FirstName,
                              LastName = user.LastName,
                              RectorNameSurname = user.FirstName + " " + user.LastName
                          }).ToList();
            ViewBag.Dean = new SelectList(result, "Id", "RectorNameSurname");

            var university = _universityBusiness.GetAll().ToList();
            ViewBag.University = new SelectList(university, "Id", "Name");


            return View();
        }

        public ActionResult ListFacultyInfo()
        {
            var result = _facultyInfo.GetAll().Select(x => new FacultyInfoViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                Phone = x.Phone,
                FaxNo = x.FaxNo,
                Email = x.Email,
                UniversityInfo = x.UniversityInfo
            });

            return View(result);
        }

        public ActionResult EditInfo(int id)
        {
            if (id > 0)
            {
                var university = _facultyInfo.GetById(id);
                if (university != null)
                {
                    var vm = new FacultyInfoViewModel
                    {
                        Id = university.Id,
                        Name = university.Name,
                        History = university.History,
                        Mission = university.Mission,
                        Vission = university.Vission,
                        Address = university.Address,
                        Phone = university.Phone,
                        FaxNo = university.FaxNo,
                        Email = university.Email,
                        DeanId = university.ApplicationUserrId,
                        DeanMessage = university.DeanMessage
                    };

                    var result = (from user in db.Users
                                  select new UserViewModel()
                                  {
                                      Id = user.Id,
                                      FirstName = user.FirstName,
                                      LastName = user.LastName,
                                      RectorNameSurname = user.FirstName + " " + user.LastName
                                  }).ToList();
                    ViewBag.Dean = new SelectList(result, "Id", "RectorNameSurname");


                    var uni = _universityBusiness.GetAll().ToList();
                    ViewBag.University = new SelectList(uni, "Id", "Name");

                    return View("AddFacultyInfo", vm);

                }

            }

            return View("AddFacultyInfo");
        }
    }
}
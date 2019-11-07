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
    public class UniversityInfoController : Controller
    {
        PiDataDbContext db;
        private ApplicationUserManager _userManager;
        private IUniversityInfoBusiness _universityInfo;
        private IAcademicCalendarBusiness _academicCalendar;


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
        public UniversityInfoController()
        {
        }
        public UniversityInfoController(IUniversityInfoBusiness universityInfo, IAcademicCalendarBusiness academicCalendar)
        {
            db = new PiDataDbContext();
            this._universityInfo = universityInfo;
            this._academicCalendar = academicCalendar;
        }

        public ActionResult AddUniversityInfo()
        {
            var result = (from user in db.Users
                          select new UserViewModel()
                          {
                              Id = user.Id,
                              FirstName = user.FirstName,
                              LastName = user.LastName,
                              RectorNameSurname = user.FirstName + " " + user.LastName
                          }).ToList();
            ViewBag.Rector = new SelectList(result, "Id", "RectorNameSurname");

            return View();
        }

        public ActionResult ListUniversityInfo()
        {
            var result = _universityInfo.GetAll().Select(x => new UniversityInfoViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                Phone = x.Phone,
                FaxNo = x.FaxNo,
                Email = x.Email
            });

            return View(result);
        }

        public ActionResult EditUniversityNews(int id)
        {
            if (id > 0)
            {
                var university = _universityInfo.GetById(id);
                if (university != null)
                {
                    var vm = new UniversityInfoViewModel
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
                        RectorId = university.ApplicationUserrId,
                        RectorMessage = university.RectorMessage
                    };

                    var result = (from user in db.Users
                                  select new UserViewModel()
                                  {
                                      Id = user.Id,
                                      FirstName = user.FirstName,
                                      LastName = user.LastName,
                                      RectorNameSurname = user.FirstName + " " + user.LastName
                                  }).ToList();
                    ViewBag.Rector = new SelectList(result, "Id", "RectorNameSurname");

                    return View("AddUniversityInfo", vm);

                }

            }

            return View("AddUniversityInfo");
        }

        public ActionResult AcademicCalendar()
        {
            var result = _academicCalendar.GetAll();
            List<AcademicCalendarViewModel> model = new List<AcademicCalendarViewModel>();

            foreach (var item in result)
            {
                model.Add(new AcademicCalendarViewModel
                {
                    Id = item.Id,
                    InfoDate = item.InfoDate,
                    Info = item.Info
                });
            }

            model = model.OrderBy(o => o.InfoDate).ToList();
            return View(model);
        }
    }
}
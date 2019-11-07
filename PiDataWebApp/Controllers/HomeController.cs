using PiData.BLL.Interface;
using PiDataApp.Repository.Context;
using PiDataWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IAcademicCalendarBusiness _academicCalendar;
        private IUniversityInfoBusiness _universityInfo;

        public HomeController(IAcademicCalendarBusiness academic, IUniversityInfoBusiness university)
        {
            this._academicCalendar = academic;
            this._universityInfo = university;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RectorMessage()
        {
            var result = _universityInfo.GetAll();
            List<UniversityInfoViewModel> model = new List<UniversityInfoViewModel>();

            foreach (var item in result)
            {
                model.Add(new UniversityInfoViewModel
                {
                    RectorMessage = item.RectorMessage
                });
            }

            return View(model);
        }

        public ActionResult History()
        {
            var result = _universityInfo.GetAll();
            List<UniversityInfoViewModel> model = new List<UniversityInfoViewModel>();

            foreach (var item in result)
            {
                model.Add(new UniversityInfoViewModel
                {
                    History = item.History
                });
            }
            return View(model);
        }

        public ActionResult MissionVision()
        {
            var result = _universityInfo.GetAll();
            List<UniversityInfoViewModel> model = new List<UniversityInfoViewModel>();

            foreach (var item in result)
            {
                model.Add(new UniversityInfoViewModel
                {
                    Mission = item.Mission,
                    Vission = item.Vission
                });
            }
            return View(model);
        }

        public ActionResult AdministrativeUnits()
        {
            return View();
        }

        public ActionResult AcademicCalendar()
        {
            var result = _academicCalendar.GetAll().ToList();
            List<AcademicCalendarViewModel> model = new List<AcademicCalendarViewModel>();

            foreach(var item in result)
            {
                model.Add(new AcademicCalendarViewModel
                {
                    Info = item.Info,
                    InfoDate = item.InfoDate
                });
            }
            return View(model);
        }

        public ActionResult Faculties()
        {
            return View();
        }

        public ActionResult Contact()
        {
            var result = _universityInfo.GetAll();
            List<UniversityInfoViewModel> model = new List<UniversityInfoViewModel>();

            foreach (var item in result)
            {
                model.Add(new UniversityInfoViewModel
                {
                    Address = item.Address,
                    Phone = item.Phone,
                    FaxNo = item.FaxNo,
                    Email = item.Email
                });
            }
            return View(model);
        }
    }
}

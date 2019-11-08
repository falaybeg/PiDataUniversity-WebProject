using PiData.BLL.Interface;
using PiDataWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Areas.Faculty.Controllers
{
    public class HomeFacultyController : Controller
    {
        private IAcademicCalendarBusiness _academicCalendar;
        private IFacultyInfoBusiness _facultyInfo;

        public HomeFacultyController(IFacultyInfoBusiness university,
            IAcademicCalendarBusiness academic)
        {
            this._academicCalendar = academic;
            this._facultyInfo = university;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DeanMessage()
        {
            var result = _facultyInfo.GetAll().Take(1);
            List<FacultyInfoViewModel> model = new List<FacultyInfoViewModel>();

            foreach (var item in result)
            {
                model.Add(new FacultyInfoViewModel
                {
                    DeanMessage = item.DeanMessage
                });
            }

            return View(model);
        }

        public ActionResult History()
        {
            var result = _facultyInfo.GetAll().Take(1);
            List<FacultyInfoViewModel> model = new List<FacultyInfoViewModel>();

            foreach (var item in result)
            {
                model.Add(new FacultyInfoViewModel
                {
                    History = item.History
                });
            }

            return View(model);
        }

        public ActionResult MissionVision()
        {
            var result = _facultyInfo.GetAll().Take(1);
            List<FacultyInfoViewModel> model = new List<FacultyInfoViewModel>();

            foreach (var item in result)
            {
                model.Add(new FacultyInfoViewModel
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

            foreach (var item in result)
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
            var result = _facultyInfo.GetAll().Take(1);
            List<FacultyInfoViewModel> model = new List<FacultyInfoViewModel>();

            foreach (var item in result)
            {
                model.Add(new FacultyInfoViewModel
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
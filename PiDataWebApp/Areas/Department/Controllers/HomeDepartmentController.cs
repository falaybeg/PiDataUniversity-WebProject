using PiData.BLL.Interface;
using PiDataWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataWebApp.Areas.Department.Controllers
{
    public class HomeDepartmentController : Controller
    {
        private IAcademicCalendarBusiness _academicCalendar;
        private IDepartmentInfoBusiness _departmentInfo;



        public HomeDepartmentController(IDepartmentInfoBusiness university,
             IAcademicCalendarBusiness academic)
        {
            this._academicCalendar = academic;
            this._departmentInfo = university;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HeadOfMessage()
        {
            var result = _departmentInfo.GetAll().Take(1);
            List<DepartmentInfoViewModel> model = new List<DepartmentInfoViewModel>();

            foreach (var item in result)
            {
                model.Add(new DepartmentInfoViewModel
                {
                    HeadDepartmentMessage = item.HeadDepartmentMessage
                });
            }

            return View(model);
        }

        public ActionResult History()
        {
            var result = _departmentInfo.GetAll().Take(1);
            List<DepartmentInfoViewModel> model = new List<DepartmentInfoViewModel>();

            foreach (var item in result)
            {
                model.Add(new DepartmentInfoViewModel
                {
                    History = item.History
                });
            }

            return View(model);
        }

        public ActionResult MissionVision()
        {
            var result = _departmentInfo.GetAll().Take(1);
            List<DepartmentInfoViewModel> model = new List<DepartmentInfoViewModel>();

            foreach (var item in result)
            {
                model.Add(new DepartmentInfoViewModel
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
            var result = _departmentInfo.GetAll().Take(1);
            List<DepartmentInfoViewModel> model = new List<DepartmentInfoViewModel>();

            foreach (var item in result)
            {
                model.Add(new DepartmentInfoViewModel
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
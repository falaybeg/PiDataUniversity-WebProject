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
    public class UniversityNewsController : Controller
    {
        private IUniversityInfoBusiness _universityBusiness;
        private IUniversityNewsBusiness _universityNewsBusiness;

        public UniversityNewsController() { }

        public UniversityNewsController(IUniversityInfoBusiness university, IUniversityNewsBusiness universityNewsBusiness)
        {
            this._universityBusiness = university;
            this._universityNewsBusiness = universityNewsBusiness;
        }


        public ActionResult AddNews()
        {
            var result = _universityBusiness.GetAll().ToList();
            List<UniversityInfoViewModel> model = new List<UniversityInfoViewModel>();
            foreach(var item in result)
            {
                model.Add(new UniversityInfoViewModel
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            ViewBag.University = new SelectList(result, "Id", "Name");

            return View();
        }

        public ActionResult ListNews()
        {
            var result = _universityNewsBusiness.GetAll().Select(x => new UniversityNewsViewModel()
            {
                Id = x.Id,
                Tittle = x.Tittle,
                Context = x.Context,
                CreatedTime = x.CreatedTime,
                UniversityInfo = x.UniversityInfo
            });

            return View(result);
        }

        public ActionResult EditNews(int id)
        {
            return View("AddNews");
        }
    }
}
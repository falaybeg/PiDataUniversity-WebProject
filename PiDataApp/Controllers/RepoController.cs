using AutoMapper;
using PiData.Domain;
using PiDataApp.Business;
using PiDataApp.Business.Interface;
using PiDataApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDataApp.Controllers
{
    public class RepoController : Controller
    {
        private ICategoryBusiness _categoryRepo;

        public RepoController(ICategoryBusiness cat)
        {
            _categoryRepo = cat;
        }

        public ActionResult Index()
        {

            ViewBag.Employee = _categoryRepo.GetEmployeeName(213);

            var listDM = _categoryRepo.GetAllEmployee();
            List<CategoryViewModel> listVM = new List<CategoryViewModel>();


            Mapper.Map(listDM, listVM);

            ViewBag.EmployeeList = listVM;

            return View();
        }

        public string AddCategory()
        {
            string result = "";

            CategoryViewModel vm = new CategoryViewModel();
            vm.Name = "Asp.Net";

            Category dm = new Category();
            Mapper.Map(vm, dm);

            result = _categoryRepo.AddUpdateCategory(dm);

            return result;
        }

    }
}
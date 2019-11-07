using PiData.BLL.Interface;
using PiData.Domain.Model;
using PiDataWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PiDataWebApp.Controllers.Api
{
    public class DepartmentInfoController : ApiController
    {

        private IDepartmentInfoBusiness _departmentInfo;
        public DepartmentInfoController()
        {

        }

        public DepartmentInfoController(IDepartmentInfoBusiness business)
        {
            this._departmentInfo = business;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var result = _departmentInfo.GetAll().Select(model => new DepartmentInfoViewModel
            {
                Id = model.Id,
                Name = model.Name,
                History = model.History,
                Mission = model.Mission,
                Vission = model.Vission,
                Address = model.Address,
                Phone = model.Phone,
                FaxNo = model.FaxNo,
                Email = model.Email,
                HeadOfDepartmentId = model.HeadOfDepartmentId,
                HeadDepartmentMessage = model.HeadDepartmentMessage
            });

            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var model = _departmentInfo.GetById(id);
            if (model != null)
            {
                DepartmentInfoViewModel VM = new DepartmentInfoViewModel
                {
                    Id = model.Id,
                    Name = model.Name,
                    History = model.History,
                    Mission = model.Mission,
                    Vission = model.Vission,
                    Address = model.Address,
                    Phone = model.Phone,
                    FaxNo = model.FaxNo,
                    Email = model.Email,
                    HeadOfDepartmentId = model.HeadOfDepartmentId,
                    HeadDepartmentMessage = model.HeadDepartmentMessage,
                };

                return Ok(VM);
            }
            return Ok("Item Not Found !");
        }

        [HttpPost]
        public IHttpActionResult Insert(DepartmentInfoViewModel model)
        {
            DepartmentInfo data = new DepartmentInfo
            {
                Id = model.Id,
                Name = model.Name,
                History = model.History,
                Mission = model.Mission,
                Vission = model.Vission,
                Address = model.Address,
                Phone = model.Phone,
                FaxNo = model.FaxNo,
                Email = model.Email,
                HeadOfDepartmentId = model.HeadOfDepartmentId,
                HeadDepartmentMessage = model.HeadDepartmentMessage
            };

            _departmentInfo.Insert(data);
            return Ok(data);
        }

        [HttpPut]
        public IHttpActionResult Update(DepartmentInfoViewModel model)
        {
            DepartmentInfo data = new DepartmentInfo
            {
                Id = model.Id,
                Name = model.Name,
                History = model.History,
                Mission = model.Mission,
                Vission = model.Vission,
                Address = model.Address,
                Phone = model.Phone,
                FaxNo = model.FaxNo,
                Email = model.Email,
                HeadOfDepartmentId = model.HeadOfDepartmentId,
                HeadDepartmentMessage = model.HeadDepartmentMessage
            };


            _departmentInfo.Update(data);
            return Ok(data);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _departmentInfo.Delete(id);
            return Ok("Deleted Successfully !");
        }
    }
}

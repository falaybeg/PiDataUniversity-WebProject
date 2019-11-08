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
    public class FacultyInfoController : ApiController
    {
        private IFacultyInfoBusiness _facultyInfo;
        public FacultyInfoController()
        {

        }

        public FacultyInfoController(IFacultyInfoBusiness business)
        {
            this._facultyInfo = business;
        }


        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var result = _facultyInfo.GetAll().Select(model => new FacultyInfoViewModel
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
                DeanId = model.ApplicationUserrId,
                DeanMessage = model.DeanMessage
            });

            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var model = _facultyInfo.GetById(id);
            if (model != null)
            {
                FacultyInfoViewModel VM = new FacultyInfoViewModel
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
                    DeanId = model.ApplicationUserrId,
                    DeanMessage = model.DeanMessage
                };

                return Ok(VM);
            }
            return Ok("Item Not Found !");
        }

        [HttpPost]
        public IHttpActionResult Insert(FacultyInfoViewModel model)
        {
            if (model != null)
            {
                FacultyInfo data = new FacultyInfo
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
                    ApplicationUserrId = model.DeanId,
                    DeanMessage = model.DeanMessage,
                    UniversityInfoId = model.UniversityId
                };
                _facultyInfo.Insert(data);
                return Ok(data);
            }

            return NotFound();
        }

        [HttpPut]
        public IHttpActionResult Update(FacultyInfoViewModel model)
        {
            if (model != null)
            {
                FacultyInfo data = new FacultyInfo
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
                    ApplicationUserrId = model.DeanId,
                    DeanMessage = model.DeanMessage
                };

                _facultyInfo.Update(data);
                return Ok(data);
            }
            return NotFound();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if(id > 0 )
            {
                _facultyInfo.Delete(id);
                return Ok("Deleted Successfully !");
            }
            return NotFound();
        }
    }
}

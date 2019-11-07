using PiData.BLL.Interface;
using PiData.BLL.ServiceBusiness;
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
    public class UniversityInfoController : ApiController
    {
        private IUniversityInfoBusiness _universityInfo;


        public UniversityInfoController()
        {

        }

        public UniversityInfoController(IUniversityInfoBusiness universityInfo)
        {
            this._universityInfo = universityInfo;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var result = _universityInfo.GetAll().Select(model => new UniversityInfoViewModel
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
                RectorId = model.ApplicationUserrId,
                RectorMessage = model.RectorMessage
            });

            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var model = _universityInfo.GetById(id);
            if (model != null)
            {
                UniversityInfoViewModel VM = new UniversityInfoViewModel
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
                    RectorId = model.ApplicationUserrId,
                    RectorMessage = model.RectorMessage,
                };

                return Ok(VM);
            }
            return Ok("Item Not Found !");
        }

        [HttpPost]
        public IHttpActionResult Insert(UniversityInfoViewModel model)
        {
            UniversityInfo data = new UniversityInfo
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
                ApplicationUserrId = model.RectorId,
                RectorMessage = model.RectorMessage
            };


            _universityInfo.Insert(data);
            return Ok(data);
        }

        [HttpPut]
        public IHttpActionResult Update(UniversityInfoViewModel model)
        {
            UniversityInfo data = new UniversityInfo
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
                ApplicationUserrId = model.RectorId,
                RectorMessage = model.RectorMessage,
            };

            _universityInfo.Update(data);
            return Ok(data);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _universityInfo.Delete(id);
            return Ok("Deleted Successfully !");
        }
    }
}

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
    public class UniversityAnnouncementController : ApiController
    {
        private IUniversityAnnouncementBusiness _universityAnnouncement;


        public UniversityAnnouncementController()
        {

        }

        public UniversityAnnouncementController(IUniversityAnnouncementBusiness _universityAnnouncement)
        {
            this._universityAnnouncement = _universityAnnouncement;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var result = _universityAnnouncement.GetAll().Select(model => new UniversityAnnouncementViewModel
            {
                Id = model.Id,
                Tittle = model.Tittle,
                Context = model.Context,
                CreatedTime = model.CreatedTime,
                UniversityId = model.UniversityId,
                UniversityInfo = model.UniversityInfo
            });

            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var model = _universityAnnouncement.GetById(id);
            if (model != null)
            {
                UniversityAnnouncementViewModel VM = new UniversityAnnouncementViewModel
                {
                    Id = model.Id,
                    Tittle = model.Tittle,
                    Context = model.Context,
                    CreatedTime = model.CreatedTime,
                    UniversityId = model.UniversityId,
                    UniversityInfo = model.UniversityInfo
                };

                return Ok(VM);
            }
            return Ok("Item Not Found !");
        }


        [HttpPut]
        public IHttpActionResult Update(UniversityAnnouncementViewModel model)
        {
            UniversityAnnouncement data = new UniversityAnnouncement
            {
                Id = model.Id,
                Tittle = model.Tittle,
                Context = model.Context,
                CreatedTime = model.CreatedTime,
                UniversityId = model.UniversityId
            };

            _universityAnnouncement.Update(data);
            return Ok(data);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _universityAnnouncement.Delete(id);
            return Ok("Deleted Successfully !");
        }
    }
}

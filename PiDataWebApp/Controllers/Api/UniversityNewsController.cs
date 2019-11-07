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
    public class UniversityNewsController : ApiController
    {
        private IUniversityNewsBusiness _universityNews;


        public UniversityNewsController()
        {

        }

        public UniversityNewsController(IUniversityNewsBusiness universityNews)
        {
            this._universityNews = universityNews;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var result = _universityNews.GetAll().Select(model => new UniversityNewsViewModel
            {
                Id = model.Id,
                Tittle = model.Tittle,
                Context = model.Context,
                CreatedTime = model.CreatedTime,
                UniversityInfoId = model.UniversityInfoId,
                UniversityInfo = model.UniversityInfo
            });

            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var model = _universityNews.GetById(id);
            if (model != null)
            {
                UniversityNewsViewModel VM = new UniversityNewsViewModel
                {
                    Id = model.Id,
                    Tittle = model.Tittle,
                    Context = model.Context,
                    CreatedTime = model.CreatedTime,
                    UniversityInfoId = model.UniversityInfoId,
                    UniversityInfo = model.UniversityInfo
                };

                return Ok(VM);
            }
            return Ok("Item Not Found !");
        }

        [HttpPost]
        public IHttpActionResult Insert(UniversityNewsViewModel model)
        {
            UniversityNews data = new UniversityNews
            {
                Id = model.Id,
                Tittle = model.Tittle,
                Context = model.Context,
                CreatedTime = DateTime.Now,
                UniversityInfoId = model.UniversityInfoId
            };

            _universityNews.Insert(data);
            return Ok(data);
        }


        [HttpPut]
        public IHttpActionResult Update(UniversityNewsViewModel model)
        {
            UniversityNews data = new UniversityNews
            {
                Id = model.Id,
                Tittle = model.Tittle,
                Context = model.Context,
                CreatedTime = model.CreatedTime,
                UniversityInfoId = model.UniversityInfoId
            };

            _universityNews.Update(data);
            return Ok(data);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _universityNews.Delete(id);
            return Ok("Deleted Successfully !");

        }
    }
}

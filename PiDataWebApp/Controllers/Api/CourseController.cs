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
    public class CourseController : ApiController
    {
        private CourseBusiness _courseBussiness;

        public CourseController()
        {

        }

        public CourseController(CourseBusiness business)
        {
            this._courseBussiness = business;
        }


        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var result = _courseBussiness.GetById(id);
            if (result != null)
            {
                CourseViewModel VM = new CourseViewModel
                {
                    Id = result.Id,
                    Code = result.Code,
                    Name = result.Description,
                    AKTS = result.AKTS,
                    CreatedTime = result.CreatedTime,
                    DepartmentId = result.DepartmentId
                };

                return Ok(VM);
            }
            return Ok("Item Not Found !");
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var result = _courseBussiness.GetAll().Select(model => new CourseViewModel
            {
                Id = model.Id,
                Code = model.Code,
                Name = model.Description,
                AKTS = model.AKTS,
                CreatedTime = model.CreatedTime,
                DepartmentId = model.DepartmentId,
                DepartmentInfo = model.DepartmentInfo,
            });

            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Insert(CourseViewModel model)
        {
            Course data = new Course
            {
                Id = model.Id,
                Code = model.Code,
                Name = model.Description,
                AKTS = model.AKTS,
                CreatedTime = DateTime.Now,
                DepartmentId = model.DepartmentId
            };


            _courseBussiness.Insert(data);
            return Ok(data);
        }

        [HttpPut]
        public IHttpActionResult Update(CourseViewModel model)
        {
            Course data = new Course
            {
                Id = model.Id,
                Code = model.Code,
                Name = model.Description,
                AKTS = model.AKTS,
                DepartmentId = model.DepartmentId
            };

            _courseBussiness.Update(data);
            return Ok(data);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _courseBussiness.Delete(id);
            return Ok("Deleted Successfully !");
        }
    }
}

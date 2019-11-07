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
    public class AcademicCalendarController : ApiController
    {
        private AcademicCalendarBusiness _academicCalendar;

        public AcademicCalendarController( )
        {
        
        }

        public AcademicCalendarController(AcademicCalendarBusiness academicCalendar)
        {
            this._academicCalendar = academicCalendar;
        }


        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var result = _academicCalendar.GetAll().Select(x => new AcademicCalendarViewModel
            {
                Id = x.Id,
                Info = x.Info,
                InfoDate = x.InfoDate
            });

            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Insert(AcademicCalendarViewModel model)
        {
            AcademicCalendar data = new AcademicCalendar
            {
               Id = model.Id,
               Info = model.Info,
               InfoDate = model.InfoDate
            };


            _academicCalendar.Insert(data);
            return Ok(data);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (id > 0)
                _academicCalendar.Delete(id);

            return Ok("Deleted " + id+ " successfuly");
        }
    }
}

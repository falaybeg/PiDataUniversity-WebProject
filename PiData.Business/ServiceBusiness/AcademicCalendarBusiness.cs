using PiData.BLL.Interface;
using PiData.DAL.Repositories;
using PiData.Domain.Model;
using PiDataApp.Repository.Infrastucture.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.BLL.ServiceBusiness
{
    public class AcademicCalendarBusiness : IAcademicCalendarBusiness
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly AcademicCalendarRepository _academicCalendarRepository;

        public AcademicCalendarBusiness(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
            this._academicCalendarRepository = new AcademicCalendarRepository(unitOfWork);
        }

        public IEnumerable<AcademicCalendar> GetAll()
        {
            var result = _academicCalendarRepository.GetAll();
            return result;
        }

        public AcademicCalendar GetById(int Id)
        {
            var result = _academicCalendarRepository.GetById(c => c.Id == Id);
            return result;
        }

        public void Insert(AcademicCalendar model)
        {
            if (model != null)
                _academicCalendarRepository.Insert(model);
        }

        public void Update(AcademicCalendar model)
        {
            if (model != null)
                _academicCalendarRepository.Update(model);
        }

        public void Delete(int Id)
        {
            if (Id != null)
                _academicCalendarRepository.Delete(c=> c.Id == Id);
        }

    }
}

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
    public class CourseBusiness : ICourseBusiness
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly CourseRepository _courseRepository;

        public CourseBusiness(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
            this._courseRepository = new CourseRepository(unitOfWork);
        }


      

        public IEnumerable<Course> GetAll()
        {
            var result = _courseRepository.GetAll();
            return result;
        }

        public Course GetById(int empId)
        {
            Course result = null;
            if (empId != null)
                result = _courseRepository.GetById(c => c.Id == empId);

            return result;
        }

        public void Insert(Course model)
        {
            if (model != null)
                _courseRepository.Insert(model);
        }

        public void Update(Course model)
        {
            if (model != null)
                _courseRepository.Update(model);
        }

        public void Delete(int Id)
        {
            if (Id != null)
                _courseRepository.Delete(x => x.Id == Id);
        }
    }
}

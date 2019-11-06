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
    public class StudentBusiness : IStudentBusiness
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly StudentRepository _studentRepository;

        public StudentBusiness(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
            this._studentRepository = new StudentRepository(unitOfWork);
        }

     

        public IEnumerable<Student> GetAll()
        {
            var result = _studentRepository.GetAll();
            return result;
        }

        public Student GetById(int empId)
        {
            Student result = null;
            if (empId != null)
                result = _studentRepository.GetById(c => c.Id == empId);

            return result;
        }

        public void Insert(Student model)
        {
            if (model != null)
                _studentRepository.Insert(model);
        }

        public void Update(Student model)
        {
            if (model != null)
                _studentRepository.Update(model);
        }

        public void Delete(int Id)
        {
            if (Id != null)
                _studentRepository.Delete(x => x.Id == Id);
        }
    }
}

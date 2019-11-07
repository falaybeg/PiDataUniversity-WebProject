using PiData.BLL.Abstract;
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
    public class FacultyInfoBusiness : IFacultyInfoBusiness
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly FacultyInfoRepository _facultyRepository;

        public FacultyInfoBusiness(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this._facultyRepository = new FacultyInfoRepository(unitOfWork);
        }

        public IEnumerable<FacultyInfo> GetAll()
        {
            var result = _facultyRepository.GetAll();
            return result;
        }

        public FacultyInfo GetById(int empId)
        {
            FacultyInfo result = null;
            if (empId != null)
                result = _facultyRepository.GetById(c => c.Id == empId);

            return result;
        }

        public void Insert(FacultyInfo model)
        {
            if (model != null)
                _facultyRepository.Insert(model);
        }

        public void Update(FacultyInfo model)
        {
            if (model != null)
                _facultyRepository.Update(model);
        }

        public void Delete(int Id)
        {
            if (Id != null)
                _facultyRepository.Delete(x => x.Id == Id);
        }
    }
}

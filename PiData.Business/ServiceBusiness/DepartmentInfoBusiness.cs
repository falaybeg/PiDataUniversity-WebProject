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
    public class DepartmentInfoBusiness : IDepartmentInfoBusiness
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly DepartmentInfoRepository _departmentRepository;

        public DepartmentInfoBusiness(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this._departmentRepository = new DepartmentInfoRepository(unitOfWork);
        }

       

        public IEnumerable<DepartmentInfo> GetAll()
        {
            var result = _departmentRepository.GetAll();
            return result;
        }

        public DepartmentInfo GetById(int empId)
        {
            DepartmentInfo result = null;
            if (empId != null)
                result = _departmentRepository.GetById(c => c.Id == empId);

            return result;
        }

        public void Insert(DepartmentInfo model)
        {
            if (model != null)
                _departmentRepository.Insert(model);
        }

        public void Update(DepartmentInfo model)
        {
            if (model != null)
                _departmentRepository.Update(model);
        }

        public void Delete(int Id)
        {
            if (Id != null)
                _departmentRepository.Delete(x => x.Id == Id);
        }
    }
}

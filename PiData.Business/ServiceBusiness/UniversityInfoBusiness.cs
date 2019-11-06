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
    public class UniversityInfoBusiness : IUniversityInfoBusiness
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UniversityInfoRepository _universityRepository;

        public UniversityInfoBusiness(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
            this._universityRepository = new UniversityInfoRepository(unitOfWork);
        }


        public IEnumerable<UniversityInfo> GetAll()
        {
            var result = _universityRepository.GetAll();
            return result;
        }

        public UniversityInfo GetById(int uniId)
        {
            UniversityInfo result = null;
            if(uniId != null)
                result = _universityRepository.GetById(c => c.Id == uniId);

            return result;
        }

        public void Insert(UniversityInfo model)
        {
            if (model != null)
                _universityRepository.Insert(model);
        }

        public void Update(UniversityInfo model)
        {
            if (model != null)
                _universityRepository.Update(model);
        }

        public void Delete(int Id)
        {
            if (Id != null)
                _universityRepository.Delete(x => x.Id == Id);
        }
    }
}

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
    public class UniversityNewsBusiness : IUniversityNewsBusiness
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly UniversityNewsRepository _universityNewsRepository;

        public UniversityNewsBusiness(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
            this._universityNewsRepository = new UniversityNewsRepository(unitOfWork);
        }

      

        public IEnumerable<UniversityNews> GetAll()
        {
            var result = _universityNewsRepository.GetAll();
            return result;
        }

        public UniversityNews GetById(int Id)
        {
            UniversityNews result = null;
            if (Id != null)
                result = _universityNewsRepository.GetById(c => c.Id == Id);

            return result;
        }

        public void Insert(UniversityNews model)
        {
            if (model != null)
                _universityNewsRepository.Insert(model);
        }

        public void Update(UniversityNews model)
        {
            if (model != null)
                _universityNewsRepository.Update(model);
        }

        public void Delete(int Id)
        {
            if (Id != null)
                _universityNewsRepository.Delete(x => x.Id == Id);
        }
    }
}

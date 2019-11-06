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
    public class UniversityAnnouncementBusiness : IUniversityAnnouncementBusiness
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UniversityAnnouncementRepository _universityAnnouncementRepository;

        public UniversityAnnouncementBusiness(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
            this._universityAnnouncementRepository = new UniversityAnnouncementRepository(unitOfWork);
        }


        public IEnumerable<UniversityAnnouncement> GetAll()
        {
            var result = _universityAnnouncementRepository.GetAll();
            return result;
        }
  
        public UniversityAnnouncement GetById(int Id)
        {
            UniversityAnnouncement result = null;
            if (Id != null)
                result = _universityAnnouncementRepository.GetById(c => c.Id == Id);

            return result;
        }

        public void Insert(UniversityAnnouncement model)
        {
            if (model != null)
                _universityAnnouncementRepository.Insert(model);
        }

        public void Update(UniversityAnnouncement model)
        {
            if (model != null)
                _universityAnnouncementRepository.Update(model);
        }

        public void Delete(int Id)
        {
            if (Id != null)
                _universityAnnouncementRepository.Delete(x => x.Id == Id);
        }
    }
}

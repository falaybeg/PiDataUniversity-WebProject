using PiData.Domain.Model;
using PiDataApp.Repository.Infrastucture;
using PiDataApp.Repository.Infrastucture.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.DAL.Repositories
{
    public class DepartmentInfoRepository : BaseRepository<DepartmentInfo>
    {
        public DepartmentInfoRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

    }
}

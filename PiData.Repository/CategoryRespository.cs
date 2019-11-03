using PiData.Domain;
using PiDataApp.Repository.Infrastucture;
using PiDataApp.Repository.Infrastucture.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiDataApp.Repository
{
    public class CategoryRespository : BaseRepository<Category>
    {
        public CategoryRespository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        
    }
}

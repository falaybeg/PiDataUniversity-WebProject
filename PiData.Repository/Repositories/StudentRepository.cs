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
    public class StudentRepository : BaseRepository<Student>
    {
        public StudentRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

    }
}

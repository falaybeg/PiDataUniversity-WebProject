using PiDataApp.Repository.Context;
using PiDataApp.Repository.Infrastucture.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiDataApp.Repository.Infrastucture
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PiDataDbContext _dbContext;

        public UnitOfWork()
        {
            _dbContext = new PiDataDbContext();
        }

        public DbContext Db
        {
            get { return _dbContext; }
        }

        public void Dispose()
        {
        }
    }
}

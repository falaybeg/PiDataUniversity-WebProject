using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiDataApp.Repository.Infrastucture.Contract
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Db { get; }
    }
}

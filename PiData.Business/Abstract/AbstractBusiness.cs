using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.BLL.Abstract
{
    public interface AbstractBusiness<T>
    {
        void Insert(T model);
        void Update(T model);
        void Delete(int Id);
        T GetById(int empId);
        IEnumerable<T> GetAll();
    }
}

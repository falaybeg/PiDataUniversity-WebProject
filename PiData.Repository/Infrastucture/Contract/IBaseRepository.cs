using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PiDataApp.Repository.Infrastucture.Contract
{
    public interface IBaseRespository<T>
    {
        T SingleOrDefault(Expression<Func<T, bool>> whereCondition);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> whereCondition);
        T Insert(T entity);
        void Update(T entity);
        void UpdateAll(IList<T> entities);
        void Delete(Expression<Func<T, bool>> whereCondition);
        bool Exist(Expression<Func<T, bool>> whereCondition);

    }
}

using PiData.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiDataApp.Business.Interface
{
    public interface ICategoryBusiness
    {
        string GetEmployeeName(int empId);
        IEnumerable<Category> GetAllEmployee();
        string AddUpdateCategory(Category model);
    }
}

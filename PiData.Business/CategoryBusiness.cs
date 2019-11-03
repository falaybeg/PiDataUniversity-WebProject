
using PiData.Domain;
using PiDataApp.Business.Interface;
using PiDataApp.Repository;
using PiDataApp.Repository.Infrastucture.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiDataApp.Business
{
    public class CategoryBusiness : ICategoryBusiness
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly CategoryRespository categoryRepository;

        public CategoryBusiness(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
            this.categoryRepository = new CategoryRespository(unitOfWork);
        }

        public string GetEmployeeName(int empId)
        {
            return "Furkan" + empId;
        }

        public IEnumerable<Category> GetAllEmployee()
        {
            var result = categoryRepository.GetAll()
                .Select(c => new Category
            {
                    Id = c.Id, 
                    Name = c.Name
            });
            return result;
        }

        public string AddUpdateCategory(Category model)
        {
            if(model.Id > 0)
            {
                var catDb = categoryRepository.SingleOrDefault(x => x.Id == model.Id);

                if(catDb != null)
                {
                    catDb.Name = model.Name;
                    categoryRepository.Update(catDb);
                    return "Updated !";
                }

            }
            else
            {
                Category catModel = new Category();
                catModel.Name = model.Name;
                categoryRepository.Insert(catModel);
                return "Inserted !";
            }
            return null;
        }
    }
}

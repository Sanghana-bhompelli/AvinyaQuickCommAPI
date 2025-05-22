using System.Collections.Generic;
using System.Threading.Tasks;
using Entity.DBLayer;
using Entity.DBLayer.Models;

namespace QuickComm.BusinessLayer
{
    public class Class1
    {
        private readonly IInterfaceentity _categoryRepository;

        public Class1(IInterfaceentity categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryModels>> GetAllCategoriesAsync()
        {
            return await _categoryRepository.GetAllCategories();
        }
    }
}


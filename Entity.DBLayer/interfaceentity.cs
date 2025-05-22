using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DBLayer.Models;

namespace Entity.DBLayer
{
    public interface IInterfaceentity
    {
        public Task<List<CategoryModels>> GetAllCategories();
    }
}

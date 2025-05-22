using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DBLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity.DBLayer
{
    public class Dbclass : IInterfaceentity
    {
        private readonly EcommerceContext _ecommerceContext;

        public Dbclass(EcommerceContext ecommercecontext)
        {
            _ecommerceContext = ecommercecontext;
        }
        public async Task<List<CategoryModels>> GetAllCategories()
        {
            //LINQ Language Integrated Query

            var Categoryresult = await _ecommerceContext.Categories.Select(
                s => new CategoryModels
                {
                    CategoryId = s.CategoryId,
                    CategoryName = s.CategoryName,
                    Description = s.Description,
                }
                ).ToListAsync();
            return Categoryresult;


        }

    }
}

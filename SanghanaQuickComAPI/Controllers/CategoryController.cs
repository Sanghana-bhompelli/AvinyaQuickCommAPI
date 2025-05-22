using Microsoft.AspNetCore.Mvc;
using QuickComm.BusinessLayer;
using Entity.DBLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CategoryController
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IEcommerceBusiness _ecommerceBusiness;

        public CategoryController(IEcommerceBusiness ecommerceBusiness)
        {
            _ecommerceBusiness = ecommerceBusiness;
        }
        [HttpGet("GetAllCategories")]
        public async Task<List<CategoryModel>> GetAllCategories()
        {
            return await _ecommerceBusiness.GetAllCategories();
        }

        [HttpGet("GetAllCustomers")]
        public async Task<List<CustomerModel>> GetAllCustomers()
        {
            return await _ecommerceBusiness.GetAllCustomers();
        }
        [HttpGet("GetAllEmployess")]
        public async Task<List<EmployessModel>> GetAllEmployess()
        {
            return await _ecommerceBusiness.GetAllEmployees();
        }
        [HttpGet("GetAllOrders")]
        public async Task<List<OrderModel>> GetAllOrders()
        {
            return await _ecommerceBusiness.GetAllOrders();
        }
        [HttpGet("GetAllOrderDetails")]
        public async Task<List<OrderDetailModel>> GetAllOrderDetails()
        {
            return await _ecommerceBusiness.GetAllOrderDetails();
        }
        [HttpGet("GetAllProducts")]
        public async Task<List<ProductModel>> GetAllProducts()
        {
            return await _ecommerceBusiness.GetAllProducts();
        }
        [HttpGet("GetAllShippers")]
        public async Task<List<ShipperModel>> GetAllShippers()
        {
            return await _ecommerceBusiness.GetAllShippers();
        }
        [HttpGet("GetAllSuppliers")]
        public async Task<List<SupplierModel>> GetAllSuppliers()
        {
            return await _ecommerceBusiness.GetAllSuppliers();
        }
    }
  
}

        




          
     
   



    

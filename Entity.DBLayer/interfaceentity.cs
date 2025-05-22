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
        public Task<List<CategoryModel>>GetAllCategories();
        public Task<List<CustomerModel>>GetAllCustomers();
        public Task<List<EmployessModel>>GetAllEmployees();
        public Task<List<OrderDetailModel>>GetAllOrderDetails();
        public Task<List<OrderModel>>GetAllOrders();
        public Task<List<ProductModel>>GetAllProducts();
        public Task<List<ShipperModel>>GetAllShippers();
        public Task<List<SupplierModel>>GetAllSuppliers();


    }
}

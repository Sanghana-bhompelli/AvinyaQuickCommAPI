using System.Collections.Generic;
using System.Threading.Tasks;
using Entity.DBLayer;
using Entity.DBLayer.Models;

namespace QuickComm.BusinessLayer
{
    public class EcommereceBusines : IEcommerceBusiness
    {
        private readonly IInterfaceentity _interfaceentity;

        public EcommereceBusines(IInterfaceentity interfaceentity)
        {
            _interfaceentity = interfaceentity;
        }

        public Task<List<CategoryModel>> GetAllCategories()
        {
            return _interfaceentity.GetAllCategories();
        }

        public Task<List<CustomerModel>> GetAllCustomers()
        {
            return _interfaceentity.GetAllCustomers();
        }
        public Task<List<EmployessModel>> GetAllEmployees()
        {
            return _interfaceentity.GetAllEmployees();
        }
        public Task<List<OrderModel>> GetAllOrders()
        {
            return _interfaceentity.GetAllOrders();
        }
        public Task<List<OrderDetailModel>> GetAllOrderDetails()
        {
            return _interfaceentity.GetAllOrderDetails();
        }
        public Task<List<ProductModel>> GetAllProducts()
        {
            return _interfaceentity.GetAllProducts();
        }
        public Task<List<ShipperModel>> GetAllShippers()
        {
            return _interfaceentity.GetAllShippers();
        }
        public Task<List<SupplierModel>> GetAllSuppliers()
        {
            return _interfaceentity.GetAllSuppliers();
        }
    }
}


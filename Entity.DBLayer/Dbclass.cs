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
        public async Task<List<CategoryModel>> GetAllCategories()
        {
            //LINQ Language Integrated Query

            var Categoryresult = await _ecommerceContext.Categories.Select(
                s => new CategoryModel
                {
                    CategoryId = s.CategoryId,
                    CategoryName = s.CategoryName,
                    Description = s.Description,
                }
                ).ToListAsync();
            return Categoryresult;


        }
        public async Task<List<CustomerModel>> GetAllCustomers()
        {
            //LINQ Language Integrated Query

            var Customerresult = await _ecommerceContext.Customers.Select(
                s => new CustomerModel
                {
                    CustomerId = s.CustomerId,
                    CustomerName = s.CustomerName,
                    ContactName = s.ContactName,
                    Address = s.Address,
                    City = s.City,
                    PostalCode = s.PostalCode,
                    Country = s.Country,
                }
                ).ToListAsync();
            return Customerresult;


        }
        public async Task<List<EmployessModel>> GetAllEmployees()
        {
            //LINQ Language Integrated Query

            var Employeesresult = await _ecommerceContext.Employesses.Select(
                s => new EmployessModel
                {
                    EmployeeId = s.EmployeeId,
                    LastName = s.LastName,
                    FirstName = s.FirstName,
                    BirthDate = s.BirthDate,
                    Photo = s.Photo,
                    Notes = s.Notes,

                }
                ).ToListAsync();
            return Employeesresult;

        }
        public async Task<List<OrderDetailModel>> GetAllOrderDetails()
        {
            //LINQ Language Integrated Query

            var OrderDetailsresult = await _ecommerceContext.OrderDetails.Select(
                s => new OrderDetailModel
                {
                    OrderDetailId = s.OrderDetailId,
                    OrderId = (int?)s.OrderId,
                    ProductId = (int?)s.ProductId,
                    Quantity = (int?)s.Quantity,
                }
                ).ToListAsync();
            return OrderDetailsresult;
        }
        public async Task<List<OrderModel>> GetAllOrders()
        {
            //LINQ Language Integrated Query

            var Ordersresult = await _ecommerceContext.Orders.Select(
                s => new OrderModel
                {
                    OrderId = s.OrderId,
                    CustomerId = (int?)s.CustomerId,
                    EmployeeId = (int?)s.EmployeeId,
                    OrderDate = s.OrderDate,
                    ShipperID=s.ShipperId
                   

                }
                ).ToListAsync();
            return Ordersresult;
        }
        public async Task<List<ProductModel>> GetAllProducts()
        {
            //LINQ Language Integrated Query

            var Productsresult = await _ecommerceContext.Products.Select(
                static s => new ProductModel
                {
                    ProductId = s.ProductId,
                    ProductName = s.ProductName,
                    SupplierId = s.SupplierId,
                    CategoryId = (int?)s.CategoryId,
                    Unit = s.Unit,
                    Price = (int?)s.Price,


                }
                ).ToListAsync();
            return Productsresult;
        }
        public async Task<List<SupplierModel>> GetAllSuppliers()
        {
            //LINQ Language Integrated Query

            var Suppliersresult = await _ecommerceContext.Suppliers.Select(
                s => new SupplierModel
                {
                    SupplierId = s.SupplierId,
                    SupplierName = s.SupplierName,
                    ContactName = s.ContactName,
                    Address = s.Address,
                    City = s.City,
                    PostalCode = s.PostalCode,
                    Country = s.Country,
                    Phone = s.Phone,

                }
                ).ToListAsync();
            return Suppliersresult;

        }
        public async Task<List<ShipperModel>> GetAllShippers()
        {

            //LINQ Language Integrated Query

            var Shipperresult = await _ecommerceContext.Shippers.Select(

                s => new ShipperModel
                {

                    ShipperId = s.ShipperId,
                    ShipperName = s.ShipperName,
                    Phone = s.Phone
                }
                ).ToListAsync();

            return Shipperresult;



        }

        
    }
}

using Microsoft.EntityFrameworkCore;
using Project0.StoreApplication.Storage.Adapters;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Domain.Abstracts;
using System.Linq;
using System.Collections.Generic;

namespace Project0.StoreApplication.Storage.Data
{

    public class DEMO
    {
        private readonly DBAdapter _db = new DBAdapter();

        public List<Customer> GetCustomer()
        {
            return _db.Customers.FromSqlRaw("select * from customer.customer").ToList();  
        }

        public List<Product> GetProduct()
        {
            return _db.Products.FromSqlRaw("select * from store.product").ToList();  
        }

        public List<Order> GetOrder()
        {
            return _db.Orders.FromSqlRaw("select * from store.orders").ToList();  
        }

        public List<Store> GetStore()
        {
            return _db.Stores.FromSqlRaw("select * from store.store").ToList();  
        }

        //Helped out by Marcus Katalenas

    }

}
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;


namespace Project0.StoreApplication.Storage.Repositories

{
    public class ProductRepository
    {
        public List<Product> Products { get; set; }
    

        public ProductRepository(){
            Products = new List<Product>()
            {
                new Product(){ProductName= "Weenie Hut Regular"},
                new Product(){ProductName = "Weenie Hut Special"},
                new Product(){ProductName = "Weenie Hut Deluxe"}
            };
    }
    }

}
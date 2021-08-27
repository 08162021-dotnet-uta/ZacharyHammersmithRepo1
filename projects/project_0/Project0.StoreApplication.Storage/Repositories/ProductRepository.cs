using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;


namespace Project0.StoreApplication.Storage.Repositories

{
    public class ProductRepository
    {
        public List<Product> Products { get; set; }

        public List<Product> Products1 { get; set; }
    

        public ProductRepository(){
            Products = new List<Product>()
            {
                new Product(){ProductName= "Krabby Patty"},
                new Product(){ProductName = "Krabby Patty w/ Blue Jelly"},
                new Product(){ProductName = "Bubble Bass Special"}
            };
        }
    }

}
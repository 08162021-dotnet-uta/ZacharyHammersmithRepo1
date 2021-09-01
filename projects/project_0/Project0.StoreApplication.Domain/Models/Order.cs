using System;
using Project0.StoreApplication.Domain.Abstracts;
using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
    public class Order
    {

        public byte OrderId {get; set;}
        public Customer customer {get; set;}
        public Store store {get; set;}
        public DateTime OrderDate {get; set;}
        public List<Product> Products {get; set;}

    }
}
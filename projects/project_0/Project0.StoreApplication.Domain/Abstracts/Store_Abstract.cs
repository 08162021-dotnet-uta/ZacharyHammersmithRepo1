using System.Collections.Generic;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{
    public abstract class Store
    {
        public byte StoreId {get; set;}
        public string Name {get; set;}
        public List<Order> Orders {get; set;}
        public List<Product> Products {get; set;}

        public override string ToString()
        {
            if (Name != null)
            {
                return Name;
            }

            else
            {
                var noName = "N/A";
                return noName;
            } 
        }
    }

}
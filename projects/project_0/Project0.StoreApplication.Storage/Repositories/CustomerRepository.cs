using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;


namespace Project0.StoreApplication.Storage.Repositories

{
    public class CustomerRepository
    {
        public List<Customer> Customers { get; set; }


        public CustomerRepository()
        {
            Customers = new List<Customer>()
            {
                new Customer(){CustomerName = "Brian Smith"},
                new Customer(){CustomerName = "Tim Gabe"},
                new Customer(){CustomerName = "Kerry Richard"}

            };
        }
    }

}
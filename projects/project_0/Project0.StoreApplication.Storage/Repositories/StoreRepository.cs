using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Storage;


namespace Project0.StoreApplication.Storage.Repositories

{
    public class StoreRepository
    {
        public List<Store> Stores { get; set; }

        public StoreRepository(){
            
            Stores = new List<Store>();

            Stores.Add(new WeenieHutGeneral());
            Stores.Add(new WeenieHutJr());

        }
    }

}
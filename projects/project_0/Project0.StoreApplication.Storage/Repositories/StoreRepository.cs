using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Storage.Adapters;


namespace Project0.StoreApplication.Storage.Repositories

{
    public class StoreRepository
    {
        public List<Store> Stores { get; set; }

        //private static readonly FileAdapter storeFileAdapter = new FileAdapter();

        public StoreRepository(){
            
            Stores = new List<Store>();

            Stores.Add(new GreenStore());
            Stores.Add(new RedStore());

        }

    }

}
using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Storage.Adapters;
using Project0.StoreApplication.Storage.Data;
using Serilog;

namespace Project0.Application.Client
{
    class Program
    {
        private DBAdapter _db = new DBAdapter();
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"/home/zacharyhammersmith/revature/zach_code/projects/project_0/Project0.StoreApplication.Storage/Data/StoreAppLog.xml").CreateLogger();

            var Exit = 0;

            while (Exit == 0){
                //Customer Client Calls
                var c = new Program();
                PrintAllCustomerNames();
                System.Console.WriteLine(c.SelectACustomer());

                //Store Client Calls
                var s = new Program();
                PrintAllStoreLocations();
                System.Console.WriteLine(s.SelectAStore());

                //Product Client Calls
                var p = new Program();
                PrintAllProductNames();
                System.Console.WriteLine(p.SelectAProduct());

                Console.WriteLine("Would you like to continue?");
                Exit = int.Parse(Console.ReadLine());
            }
            ExitScreen();

        }

        static void PrintAllStoreLocations()
        {
            try
            {
                Log.Information("Application Store Loading");

                var StoreRepository = new StoreRepository();
                int listNum = 1;

                Console.WriteLine("\n\n----------------\n\n");

                foreach(var store in StoreRepository.Stores)
                {
                    System.Console.WriteLine(listNum + ". " + store);
                    listNum++;
                }

                Console.WriteLine("\nPlease select one of our stores by number!");
            }

            catch (Exception e)
            {
                Log.Fatal("Application Failed Loading");
                Log.Fatal("Here's Why:", e);
            }
            
        }

        Store SelectAStore()
        {
            var sr = new StoreRepository().Stores;

            var storeDb = new DEMO();

            var store = storeDb.GetStore()[int.Parse(Console.ReadLine()) - 1];
            
            return store;
        }

        static void PrintAllProductNames()
        {
            try
            {
                Log.Information("Application Product Loading");

                var ProductRepository = new ProductRepository();
                int listNum = 1;

                Console.WriteLine("\n\n----------------\n\n");

                foreach (var product in ProductRepository.Products)
                {
                    Console.WriteLine(listNum + ". " + product);
                    listNum++;
                }
            
                Console.WriteLine("\nPlease select one of our finest products!");
            }
            catch (Exception e)
            {
                Log.Fatal("Application Failed Loading");
                Log.Fatal("Here's Why:", e);
            }
        }

        Product SelectAProduct()
        {
            var sr = new ProductRepository().Products;

            var prodDb = new DEMO();

            var prod = prodDb.GetProduct()[int.Parse(Console.ReadLine()) - 1];

            return prod;
        }

        static void PrintAllCustomerNames()
        {
            var CustomerRepository = new CustomerRepository();

            
        }

        Customer SelectACustomer()
        {
            var sr = new CustomerRepository().Customers;

            var storedb = new DEMO();

            var custDb = storedb.GetCustomer()[int.Parse(Console.ReadLine()) - 1];

            return custDb;
        }

        static void ExitScreen()
        {
            Log.Information("Application Exit");
            Console.WriteLine("Thank you for your business. Come again soon!");
        }

        static int ExitInput()
        {
            var exit = int.Parse(Console.ReadLine());
            return exit;
        }

    }
}

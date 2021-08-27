using System;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.Application.Client
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //Exit Screen Call
            ExitScreen();
            ExitInput();

        }

        static void PrintAllStoreLocations()
        {
            var StoreRepository = new StoreRepository();
            int listNum = 1;

            Console.WriteLine("\n\n----------------\n\n");

            foreach(var store in StoreRepository.Stores)
            {
                System.Console.WriteLine(listNum + "-" + store);
                listNum++;
            }

            Console.WriteLine("\nPlease select one of our stores by number!");
            
        }

        Store SelectAStore()
        {
            var sr = new StoreRepository().Stores;

            var option = int.Parse(Console.ReadLine());
            var store = sr[option - 1];

            return store;

        }

        static void PrintAllProductNames()
        {
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

        Product SelectAProduct()
        {
            var sr = new ProductRepository().Products;

            var option = int.Parse(Console.ReadLine());
            var product = sr[option - 1];

            return product;
        }

        static void PrintAllCustomerNames()
        {
            var CustomerRepository = new CustomerRepository();

            Console.WriteLine("Welcome to WeenieHut.Inc App!\n");

            foreach (var customer in CustomerRepository.Customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("\nWhat is your name?");
        }

        Customer SelectACustomer()
        {
            var sr = new CustomerRepository().Customers;

            var option = int.Parse(Console.ReadLine());
            var customer = sr[option - 1];

            return customer;
        }

        static void ExitScreen()
        {
            Console.WriteLine("Thank you for your business. Would like to continue?");
        }

        static int ExitInput()
        {
            var exit = int.Parse(Console.ReadLine());
            return exit;
        }

    }
}

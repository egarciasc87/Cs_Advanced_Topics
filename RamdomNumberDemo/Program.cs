using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamdomNumberDemo;

namespace RamdomNumberDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Random numbers
            //Random random = new Random();
            //RandomNumbers rd = new RandomNumbers();
            //rd.ListRandomNumbers(random);
            //rd.ListRandomPeople(random);


            //Interfaces
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = new CustomerModel();

            foreach (var item in cart)
            {
                item.ShipItem(customer.GetDefaultCustomer());
            }

            Console.ReadLine();
        }

        public static List<IProductModel> AddSampleData()
        {
            List<IProductModel> list =
                new List<IProductModel>();
            list.Add(new PhysicalProductModel { Title = "Laptop" });
            list.Add(new PhysicalProductModel { Title = "Smart phone" });
            list.Add(new PhysicalProductModel { Title = "Coffee maker" });
            list.Add(new DigitalProductModel { Title = "Digital Book: C# 101" });

            return list;
        }

        
    }
}

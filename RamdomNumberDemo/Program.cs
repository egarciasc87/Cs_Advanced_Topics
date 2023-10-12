using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamdomNumberDemo;

namespace RamdomNumberDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ////Random numbers
            //Random random = new Random();
            //RandomNumbers rd = new RandomNumbers();
            //rd.ListRandomNumbers(random);
            //rd.ListRandomPeople(random);


            ////Interfaces
            //List<IProductModel> cart = AddSampleData();
            //CustomerModel customer = new CustomerModel();

            //foreach (var item in cart)
            //{
            //    item.ShipItem(customer.GetDefaultCustomer());
            //}

            //Console.ReadLine();


            //Abstract Classes
            //List<DataAccess> dataAccess = new List<DataAccess>
            //{
            //    new SqlDataAccess(),
            //    new SqlliteDataAccess()
            //};

            //foreach (var r in dataAccess)
            //{
            //    r.LoadConnectionString("demo");
            //    r.LoadData("select * from table");
            //    r.SaveData("insert into table...");
            //    Console.WriteLine("Success!!! \n");
            //}


            //Asyn, await, task
            //AsyncAwaitTask.MakeTea();
            //await AsyncAwaitTask.MakeTeaAsync();

            //AsyncAwaitTask.Method1Async();
            //AsyncAwaitTask.Method2Async();

            AsyncAwaitTask.ListNumbers();

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

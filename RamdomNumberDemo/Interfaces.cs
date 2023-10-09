using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamdomNumberDemo
{
    public interface IProductModel
    {
        string Title { get; set; }
        bool HasOrderBeenCompleted { get; }
        void ShipItem(CustomerModel customer);
    }


    public class PhysicalProductModel : PhysicalProductBase, IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine("Item " + Title + 
                    " has been shipped to " + 
                    customer.FirstName + " " + customer.LastName);
                HasOrderBeenCompleted = true;
            }
        }

        //public List<IProductModel> GetProducts()
        //{
        //    List<IProductModel> list =
        //        new List<IProductModel>();
        //    list.Add(new PhysicalProductModel { Title = "Laptop" });
        //    list.Add(new PhysicalProductModel { Title = "Smart phone" });
        //    list.Add(new PhysicalProductModel { Title = "Coffee maker" });
            
        //    return list;
        //}
    }


    public class PhysicalProductBase
    {

    }


    public class DigitalProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }
        public int TotalDownloadsLeft { get; private set; } = 5;
        
        public void ShipItem(CustomerModel customer)
        {
            if (TotalDownloadsLeft == 0)
            {
                Console.WriteLine("WARNING: No more downloads available");
                return;
            }

            if (HasOrderBeenCompleted == true)
            {
                Console.WriteLine("WARNING: Item has already been shipped");
                return;
            }

            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine("Item " + Title +
                    " has been sent to " +
                    customer.EmailAddress);
                HasOrderBeenCompleted = true;
                TotalDownloadsLeft--;
            }
        }
    }


    public class CustomerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        
        public CustomerModel GetDefaultCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Carlos",
                LastName = "Vera",
                City = "Lima",
                EmailAddress = "cvera@gmail.com",
                PhoneNumber = "991 673 990"
            };
        }
    }
}

using FactoryPatternBestPractices.Interfaces;
using FactoryPatternBestPractices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternBestPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            ICustomer customer = Factory.GetCustomer();
            customer.FirstName = "Kenan";
            customer.LastName = "Kurda";
            customer.Address = "Gent";
            customer.Email = "kenan@someprovider.com";
            customer.PhoneNumber = "123456789";

            //Order order = new Order();
            IOrder order = Factory.GetOrder(); ;
            order.Articel = "Table";
            order.Amount = 1;
            order.Price = 125.25m;
            order.Customer = customer;
            order.OrderConfirmation();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsGridBS.Models
{
    public class Customer
    {
        private string  name  { get; set; }
        private string order { get; set; }

        public Customer(string Name, string Order)
        {
            this.name = Name;
            this.order = Order;
        }
        public void SendOrder()
        {
            Console.WriteLine("Sended"); 
        }
        public void ReciveOrder()
        {
            Console.WriteLine("Recoved");
        }
    }
}
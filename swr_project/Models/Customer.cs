using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using swr_project.controllers;

namespace swr_project.Models
{
   public class Customer:User
    {
        public List<Order>? customerOrders { get; set; }
        public Customer(string firstName, string lastName, string fullName, string adress, int phoneNumber, string email, string type, string gender, string password, List<Order> customerOrders)
           : base( firstName, lastName, fullName, adress, phoneNumber, email, type, gender, password)
        {
            this.customerOrders = customerOrders;
        }
        public Customer()
        {
        }


    }
}

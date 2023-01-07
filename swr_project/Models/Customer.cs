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
        // list of orders

        public List<Vehicles> customersOrders { get; set; } =  new List<Vehicles>();
        public Customer(string firstName, string lastName, string fullName, string adress, string phoneNumber, string email, string type, string gender, string password, Vehicles customerOrder)
           : base( firstName, lastName, fullName, adress, phoneNumber, email, type, gender, password)
        {
            
            this.customersOrders.Add(customerOrder);

        }
        public Customer(string firstName, string lastName, string fullName, string adress, string phoneNumber, string email, string type, string gender, string password)
          : base(firstName, lastName, fullName, adress, phoneNumber, email, type, gender, password)
        {
            

        }
        public Customer()
        {
        }


    }
}

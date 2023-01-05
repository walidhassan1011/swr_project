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
        DB_helpers db = new DB_helpers();

        public Customer(string firstName, string lastName, string fullName, string adress, int phoneNumber, string email, string type, string gender, string password)
           : base( firstName, lastName, fullName, adress, phoneNumber, email, type, gender, password)
        {

        }
        public Order customerOrders { get; set; }
        
    }
}

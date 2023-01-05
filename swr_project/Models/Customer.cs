using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swr_project.Models
{
   public class Customer:User
    {
        public Customer(string firstName, string lastName, string adress, int phoneNumber, string Email, string type, string Password)
           : base( firstName, lastName, adress, phoneNumber, Email, type, Password)
        {

        }
        public Order customerOrders { get; set; }
        public void addOrder()
        {

        }
        public void removeOrder()
        {

        }
        public void editOrder()
        {

        }
    }
}

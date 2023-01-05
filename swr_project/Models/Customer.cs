using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swr_project.Models
{
   public class Customer:User
    {
        public Customer(string firstName, string lastName, string fullName, string adress, int phoneNumber, string email, string type, string gender, string password)
           : base( firstName, lastName, fullName, adress, phoneNumber, email, type, gender, password)
        {

        }
        public Order customerOrders { get; set; }
        public void addOrder(Order order)
        {

        }
        public void removeOrder(Order order)
        {

        }
        public void editOrder(Order orderOld, Order orderNew)
        {

        }
    }
}

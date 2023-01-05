using swr_project.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swr_project.Models
{
    public class Admin:Employee
    {

        public Admin(string firstName, string lastName, string adress, int phoneNumber, string Email, string type, string Password)
           : base(firstName, lastName, adress, phoneNumber, Email, type, Password)
        {

        }
        public void viewAllCustomers()
        {

        }
        public void addCustomer()
        {

        }
        public void editCustomer()
        {

        }public void removeCustomer()
        {

        }
    }
}

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

        public Admin(string firstName, string lastName, string fullName, string adress, int phoneNumber, string email, string type, string gender, string password)
           : base( firstName, lastName, fullName, adress, phoneNumber, email, type, gender, password)
        {

        }
        public List<User> viewAllUsers()
        {
            var usersList = new List<User>();
            return usersList;
        }
        public void addUser(User user)
        {

        }
        public void editUser(User userOld, User userNew)
        {

        }public void removeUser(User user)
        {

        }
    }
}

﻿using swr_project.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swr_project.Models
{
    public class Admin:Employee
    {
        DB_helpers db = new DB_helpers();

        public Admin(string firstName, string lastName, string fullName, string adress, string phoneNumber, string email, string type, string gender, string password)
           : base( firstName, lastName, fullName, adress, phoneNumber, email, type, gender, password)
        {

        }
        public Admin()
        {

        }
       
        public void addUser(User user)
        {
            db.AddNewUser(user);
        }
       
        public void removeUser(string Id)
        {
            db.DeleteUser(Id);
        }
    }
}

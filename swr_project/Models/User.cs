using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using swr_project.controllers;

namespace swr_project.Models
{
    public class User
    {
        DB_helpers db = new DB_helpers();

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }

        public string fullName { get; set; }
        public string adress { get; set; }
        public int phoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime created { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public string Password { get; set; }
        public User( string firstName, string lastName, string fullName, string adress, int phoneNumber, string email, string type, string gender, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fullName = fullName;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
            this.Email = email;
            this.type = type;
            this.created = DateTime.Now;
            this.gender = gender;
            this.Password = password;
        }
        public User()
        {
        }
        public Customer FinUserById(string id)
        {

            return db.FindUserById(id);

        }
        public List<Vehicles> viewAllVehicles()
        {
            var VehiclesList = new List<Vehicles>();
            VehiclesList = db.viewAllVehicles();
            return VehiclesList;
        }
        public List<Customer> viewAllUsers()
        {
            var UsersList = new List<Customer>();
            UsersList = db.GetAllUsers();
            return UsersList;
        }
        public void addNewOrder(Order order)
        {
            db.AddNewOrder(order);
        }
        public List<Order> viewAllOrders()
        {
            var OrderList =  db.GetAllOrders();
            return OrderList;
        }
        public List<User> GetAllEmployees()
        {

            var EmployeeList = db.GetAllEmployee();
            return EmployeeList;
            
        }
        public void deleteOrder(Order order) 
        {
            //We need to make the method of deleting in the database .
        }
        public void editOrder(Order orderOld, Order orderNew)
        {
            db.UpdateOrder(orderOld);//We need to modify the method in the database to take the new order.
        }
        public void maintenanceAgency()
        {
            //We need to make the Maintennace first.
        }
        public void addMaintenanceAgency()
        {
            //We need to make the Maintennace first.
        }
        public void deleteMaintenanceAgency()
        {
            //We need to make the Maintennace first.
        }
        public void editMaintenaceAgency()
        {
            //We need to make the Maintennace first.
        }
        public void viewAllMaintenaceAgency()
        {
            //We need to make the Maintennace first.
        }
    }
}

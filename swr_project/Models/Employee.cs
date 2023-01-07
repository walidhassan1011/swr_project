using swr_project.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swr_project.Models
{
    public class Employee:User
    {
        DB_helpers db = new DB_helpers();
        public Employee(string firstName, string lastName, string fullName, string adress, int phoneNumber, string email, string type, string gender, string password)
           : base( firstName, lastName, fullName, adress, phoneNumber, email, type, gender, password)
        {

        }
        public Employee()
        {

        }
        public Customer FinUserById(string id)
        {

            return db.FindUserById(id);

        }
        public void editUser(Customer user)
        {
            db.UpdateUser(user);
        }
        public List<Vehicles> viewAllVehicles()
        {
            var VehiclesList = new List<Vehicles>();
            VehiclesList = db.viewAllVehicles();
            return VehiclesList;
        }

        public void DeleteVehicle(string id)
        {
            db.DeleteVehicle(id);
        }

        public List<Customer> viewAllUsers()
        {
            var UsersList = new List<Customer>();
            UsersList = db.GetAllUsers();
            return UsersList;
        }

        public Order findOrderById(string id)
        {
            return db.FindOrderById(id);
        }

        public Task addNewOrder(Order order)
        {
            return db.AddNewOrder(order);
        }
        public List<Order> viewAllOrders()
        {
            var OrderList = db.GetAllOrders();
            return OrderList;
        }
        public List<Employee> GetAllEmployees()
        {

            var EmployeeList = db.GetAllEmployee();
            return EmployeeList;

        }

        public Vehicles FindVehicleById(string id)
        {
            return db.FindVehicleById(id);
        }

        public void deleteOrder(string orderId)
        {
            db.DeleteOrder(orderId);
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

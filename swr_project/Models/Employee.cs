using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swr_project.Models
{
    public class Employee:User
    {
        public Employee(string firstName, string lastName, string adress, int phoneNumber, string Email, string type, string Password)
           : base(firstName, lastName, adress, phoneNumber, Email, type, Password)
        {

        }
        public void addNewCar()
        {
            
        }
        
        public void editCar()
        {

        }

        public void removeCar()
        {

        }
        public void maintenanceAgency()
        {

        }
        public void addMaintenanceAgency()
        {

        }
        public void deleteMaintenanceAgency()
        {

        }
        public void editMaintenaceAgency()
        {

        }
        public void viewAllMaintenaceAgency()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swr_project.Models
{
    public class Employee:Person
    {
        public Employee(string firstName, string lastName, string adress, int phoneNumber, string Email, string type, string password) : base()
        {

        }
        public void addNewCar()
        {
            Car car = new Car();
        }
        
        public void editCar()
        {

        }

        public void removeCar()
        {

        }
    }
}

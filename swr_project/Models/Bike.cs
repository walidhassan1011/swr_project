using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swr_project.Models
{
    public class Bike : Vehicles

    {

        public Bike(string fuelType, string model, string brand, string year, string chasis_Number, double price, string engine_Number, string serialNumber) 
            : base(fuelType, model, brand, year, chasis_Number, price, engine_Number, serialNumber)
        {

        }
        public void addNewBike()
        {
            
        }
        public void editBike()
        {
            
        }
        public void removeBike()
        {

        }
        public void viewAllBike()
        {

        }
    }
}

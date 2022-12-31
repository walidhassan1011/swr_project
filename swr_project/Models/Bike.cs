using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swr_project.Models
{
    public class Bike
    {
        public Bike( string fuelType, string model, string brand, string year, string chasis_Number, double price, string engine_Number, string serialNumber) 
            : base()
        {

        }
        public Bike addNewBike()
        {
            Bike bike = new Bike();
            return bike;
        }
        public Bike editBike()
        {
            Bike bike =new Bike();
            return bike;
        }
        public void removeBike()
        {

        }
        public void viewAllBike()
        {

        }
    }
}

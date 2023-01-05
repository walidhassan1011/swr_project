using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swr_project.Models
{
   public class Car : Vehicles
    {
        public Car(string fuelType, string model, string brand, string year, string chasis_Number, double price, string engine_Number, string serialNumber)
           : base(fuelType, model, brand, year, chasis_Number, price, engine_Number, serialNumber)
        {

        }
        public void addNewCar(Vehicles vehicle)
        {

        }
        public void editCar(Vehicles vehicleOld,Vehicles vehicleNew)
        {

        }
        public void removeCar(Vehicles vehicle)
        {

        }
        public List<Vehicles> viewAllCars()
        {
            var carsList=new List<Vehicles>();
            return carsList;
        }
    }
}

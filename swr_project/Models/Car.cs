using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using swr_project.controllers;

namespace swr_project.Models
{
   public class Car : Vehicles
    {
        DB_helpers db = new DB_helpers();
        public Car(string fuelType, string model, string brand, string year, string chasis_Number, double price, string engine_Number, string serialNumber)
           : base(fuelType, model, brand, year, chasis_Number, price, engine_Number, serialNumber)
        {

        }
        public void addNewCar(Vehicles vehicle)
        {
            db.AddNewVehicle(vehicle);
        }
        public void editCar(Vehicles vehicleOld,Vehicles vehicleNew)
        {
            db.UpdateVehicle(vehicleOld);//We need to modify the method in the database to take the new vehicle too.
        }
        public void removeCar(Vehicles vehicle)
        {
            db.DeleteVehicle(vehicle);
        }
        public List<Vehicles> viewAllCars()
        {
            var carsList=new List<Vehicles>();
            return carsList;
        }
    }
}

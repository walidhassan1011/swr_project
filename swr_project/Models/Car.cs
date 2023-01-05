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
        public Car(string fuelType, string model, string brand, string type, double price, string engine_Number, string serialNumber)
           : base(fuelType, model, brand, type,price, engine_Number, serialNumber)
        {

        }
        public Task addNewCar(Car newCar)
        {
            
            return db.AddNewVehicle(newCar);
        }
        public void editCar(Car vehicleOld,Car vehicleNew)
        {
            db.UpdateVehicle(vehicleOld);//We need to modify the method in the database to take the new vehicle too.
        }
        public void removeCar(Car car)
        {
            db.DeleteVehicle(car);
        }
        public List<Vehicles> viewAllCars()
        {
            var carsList=new List<Vehicles>();
            return carsList;
        }
    }
}

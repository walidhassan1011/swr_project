using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using swr_project.controllers;

namespace swr_project.Models
{
    public class Bike : Vehicles

    {
        DB_helpers db = new DB_helpers();

        public Bike(string fuelType, string model, string brand, string type, double price, string engine_Number, string serialNumber) 
            : base(fuelType, model, brand, type, price, engine_Number, serialNumber)
        {

        }
        public Task addNewBike(Vehicles vehicle)
        {
           return db.AddNewVehicle(vehicle);
        }
        public void editBike(Vehicles vehicleOld, Vehicles vehiclesNew)
        {
            db.UpdateVehicle(vehicleOld);//We need to modify the method to take the new vehicle too.
        }
        public void removeBike(string vehicleId)
        {
            db.DeleteVehicle(vehicleId);
        }
        
    }
}

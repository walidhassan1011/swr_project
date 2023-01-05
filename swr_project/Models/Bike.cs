﻿using System;
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

        public Bike(string fuelType, string model, string brand, string year, string chasis_Number, double price, string engine_Number, string serialNumber) 
            : base(fuelType, model, brand, year, chasis_Number, price, engine_Number, serialNumber)
        {

        }
        public void addNewBike(Vehicles vehicle)
        {
            db.AddNewVehicle(vehicle);
        }
        public void editBike(Vehicles vehicleOld, Vehicles vehiclesNew)
        {
            db.UpdateVehicle(vehicleOld);//We need to modify the method to take the new vehicle too.
        }
        public void removeBike(Vehicles vehicle)
        {
            db.DeleteVehicle(vehicle);
        }
        public List<Vehicles> viewAllBike()
        {
            var bikeList = new List<Vehicles>();
            return bikeList;
        }
    }
}

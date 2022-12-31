using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swr_project.Models
{
    public class Vehicles
    {
        public string Id { get; set; }
        public string fuelType { get; set; }
        public string Model { get; set; }
        public string brand { get; set; }
        public string year { get; set; }
        public string chasis_Number { get; set; }
        public double price { get; set; }
        public string Engine_Number { get; set; }
        public string serialNumber { get; set; }
        public Vehicles(string id, string fuelType, string model, string brand, string year, string chasis_Number, double price, string engine_Number, string serialNumber)
        {
            Id = id;
            this.fuelType = fuelType;
            Model = model;
            this.brand = brand;
            this.year = year;
            this.chasis_Number = chasis_Number;
            this.price = price;
            Engine_Number = engine_Number;
            this.serialNumber = serialNumber;
        }
    }

}

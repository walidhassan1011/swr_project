using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using swr_project.controllers;

namespace swr_project.Models
{
    public class Vehicles
    {
        DB_helpers db = new DB_helpers();

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string fuelType { get; set; }
        public string Model { get; set; }
        public string brand { get; set; }
       
        public DateTime TimeStamp { get; set; }
        public string Type { get; set; }
        public double price { get; set; }
        public string Engine_Number { get; set; }
        public string serialNumber { get; set; }
        public Vehicles(string fuelType, string model, string brand, string type, double price, string engine_Number, string serialNumber)
        {
            this.fuelType = fuelType;
            Model = model;
            this.brand = brand;
            this.Type = type;
            this.TimeStamp = DateTime.Now;
            this.price = price;
            Engine_Number = engine_Number;
            this.serialNumber = serialNumber;
        }
       
    }

}

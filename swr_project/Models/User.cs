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
    public class User
    {
        DB_helpers db = new DB_helpers();

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }

        public string fullName { get; set; }
        public string adress { get; set; }
        public int phoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime created { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public string Password { get; set; }
        public User( string firstName, string lastName, string fullName, string adress, int phoneNumber, string email, string type, string gender, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fullName = fullName;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
            this.Email = email;
            this.type = type;
            this.created = DateTime.Now;
            this.gender = gender;
            this.Password = password;
        }
        public User()
        {
        }
        
    }
}

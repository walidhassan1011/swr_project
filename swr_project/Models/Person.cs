using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace swr_project.Models
{
    public class Person
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }

        public string fullName { get; set; }
        public string adress { get; set; }
        public int phoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime created { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public string password { get; set; }
        public Person(string firstName, string lastName, string adress, int phoneNumber, string Email, string type, string password)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.fullName = firstName + lastName;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
            this.Email = Email;
            this.type = type;
            this.password = password;
        }


    }
}
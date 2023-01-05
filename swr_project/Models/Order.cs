using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swr_project.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public Customer orderBy { get; set; }
        public DateTime createdAt { get; set; }
        public void OrderBy()
        {

        }
        public void YourOrder()
        {

        }
        public void viewAllOrders()
        {

        }
    }
}

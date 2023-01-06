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
        public string orderBy { get; set; }

        public string order { get; set; }
        public DateTime createdAt { get; set; }

        
        public Order(String orderBy,string order)
        {
            this.orderBy = orderBy;
            this.order=order;
            this.createdAt = DateTime.Now;
        }

        public Order()
        {
        }
        public void OrderBy(Customer customer)
        {
            //We need to make the method in database first.
        }
        public void YourOrder(Invoice invoice)
        {
            //We need to make the method in database first.
        }
        
    }
}
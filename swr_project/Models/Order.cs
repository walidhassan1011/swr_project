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
        public Vehicles order { get; set; }
        public DateTime createdAt { get; set; }

        
        public Order(Vehicles order,Customer orderBy)
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
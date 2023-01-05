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
    public class Invoice
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int _id { get; set; }
        
        
        public float product_price { get; set; }

        public string product_name { get; set; }

        public Customer invoice_name { get; set; }

        public void addNewInvoice(Invoice invoice)
        {
            /*invoice_name = new Customer();
            this.invoice_id = invoice_id;
            this.product_price = product_price;
            this.product_name = product_name;*/

        }

        public void deleteInvoice(Invoice invoice)
        {

        }

        public void editInvoice(Invoice invoiceOld, Invoice invoiceNew)
        {
            
        }
        
    }
}

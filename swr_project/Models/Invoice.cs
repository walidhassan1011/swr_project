using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using swr_project.controllers;
using MongoDB.Bson.Serialization.Attributes;

namespace swr_project.Models
{
    public class Invoice
    {
        DB_helpers db = new DB_helpers();

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int _id { get; set; }
        
        
        public float product_price { get; set; }

        public string product_name { get; set; }

        public Customer invoice_name { get; set; }

        public void addNewInvoice(Invoice invoice)
        {
            db.AddNewInvoice(invoice);
        }

        public void deleteInvoice(Invoice invoice)
        {
            db.DeleteInvoice(invoice);
        }

        public void editInvoice(Invoice invoiceOld, Invoice invoiceNew)
        {
            db.UpdateInvoice(invoiceNew);//We need to modify the method in database to take the old invoice too.
        }
        
    }
}

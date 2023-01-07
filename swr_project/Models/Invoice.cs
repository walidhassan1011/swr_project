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
        
        
        public double product_price { get; set; }

        public string product_name { get; set; }

        public Customer customerDetails { get; set; }

        public string createdAt { get; set; }

        public Invoice(double product_price, string product_name, Customer customerDetails)
        {
            this.product_price = product_price;
            this.product_name = product_name;
            this.customerDetails = customerDetails;
            this.createdAt = DateTime.Now.ToString("M/d/yyyy");
        }
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

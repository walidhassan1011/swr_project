using MongoDB.Driver;
using MongoDB.Bson;
using System;

using swr_project.Models;

namespace swr_project.controllers
{
    public class DB_helpers
    {
        private const string connectionString = "mongodb+srv://walid:walidhassan1011@cluster0.b9m9hni.mongodb.net/?retryWrites=true&w=majority";
        private const string dbName = "swr_project";
        private const string invoicesCollection = "invoices";
        private const string customersCollection = "customers";
        private const string carCollection = "cars";
        private const string bikeCollection = "bikes";
        private const string employeeCollection = "employees";
        private const string adminCollection = "admins";

        private IMongoCollection<T>ConnectMongo<T>(in string collection)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(dbName);
            return  database.GetCollection<T>(collection);

            
        }
        // invoices
        public void addNewInvoice(Invoice invoice)
        {
            var collection = ConnectMongo<Invoice>(invoicesCollection);
            collection.InsertOneAsync(invoice);
        }
        // user

        // car
        // bike
        // customers
        // order
        // admin
        // employee 


    }
}

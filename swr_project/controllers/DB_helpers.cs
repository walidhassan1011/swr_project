using MongoDB.Driver;
using MongoDB.Bson;
using System;
using BCrypt.Net;
using swr_project.Models;

namespace swr_project.controllers
{
    public class DB_helpers
    {
        private const string connectionString = "mongodb+srv://walid:walidhassan1011@cluster0.b9m9hni.mongodb.net/?retryWrites=true&w=majority";
        private const string dbName = "swr_project";
        private const string invoicesCollection = "invoices";
        private const string usersCollection = "users";
        private const string VehiclesCollection = "Vehicles";
        private const string OrdersCollection = "orders";



        private IMongoCollection<T>ConnectMongo<T>(in string collection)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(dbName);
            return  database.GetCollection<T>(collection);

            
        }
        // invoices
        public void AddNewInvoice(Invoice invoice)
        {
            try
            {
                var collection = ConnectMongo<Invoice>(invoicesCollection);
                collection.InsertOneAsync(invoice);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateInvoice(Invoice invoice)
        {
            try
            {
                var collection = ConnectMongo<Invoice>(invoicesCollection);
                var filter = Builders<Invoice>.Filter.Eq("_id", invoice._id);
                collection.ReplaceOneAsync(filter, invoice, new ReplaceOptions { IsUpsert = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        public void DeleteInvoice(Invoice invoice)
        {
            try {
                var collection = ConnectMongo<Invoice>(invoicesCollection);
                var filter = Builders<Invoice>.Filter.Eq("_id", invoice._id);
                if (collection.DeleteOneAsync(filter).Result.DeletedCount == 0)
                {
                    MessageBox.Show("Invoice not found");
                }
                else
                {
                collection.DeleteOneAsync(filter);
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("something wrong");
            }
        }

        
        // Customer
        public async void  AddNewUser(User user)
        {
            try
            {
                var collection = ConnectMongo<User>(usersCollection);

                var filter = Builders<User>.Filter.Eq("email", user.Email);

                if (collection.Find(filter).FirstOrDefaultAsync().Result != null)
                {
                    MessageBox.Show("Email already exists");
                }
                else
                {
                    user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                    await collection.InsertOneAsync(user);
                }


               
               
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            
        
    }
        }
        
        public void UpdateUser(User oldUser,User newUser)
        {
            try
            {
                
                var collection = ConnectMongo<User>(usersCollection);
                var filter = Builders<User>.Filter.Eq("_id", oldUser._id);
                collection.ReplaceOneAsync(filter, newUser, new ReplaceOptions { IsUpsert = true });
            }
            catch (Exception ex)
            {
                    
            }
        }
        public User FindUser(string name,string Password)
        {


            var collection = ConnectMongo<User>(usersCollection);
            var filter = Builders<User>.Filter.Eq("firstName", name);
            var user= collection.Find(filter).FirstOrDefault();
            if (user == null)
            {
                return null;
            }
            else
            {

            if (BCrypt.Net.BCrypt.Verify(Password, user.Password))
            {
                return user;
            }
            else
            {
                return null;
            }
            }
            
            
        }
        public void DeleteUser(User user)
        {
            try
            {
                var collection = ConnectMongo<User>(usersCollection);
                
               if (collection.DeleteOneAsync(c => c._id == user._id).Result.DeletedCount == 1)
                {
                    MessageBox.Show("deleted");
                }
                else
                {
                    MessageBox.Show("not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    
        }
        

        
        // car
            
            public async Task<List<Vehicles>> GetAllVehicles()
        {
            try
            {
                var collection = ConnectMongo<Vehicles>(VehiclesCollection);
                return await collection.Find(
                    _ => true).ToListAsync();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }

        }

            public void AddNewVehicle(Vehicles vehicle)
        {
            try
            {
                var collection = ConnectMongo<Vehicles>(VehiclesCollection);
                collection.InsertOneAsync(vehicle);
            }
            catch (Exception ex)
            {
                
            }
            
            }

        public Task UpdateVehicle(Vehicles oldvVehicle)
        {
            try
            {
                var collection = ConnectMongo<Vehicles>(VehiclesCollection);
                var filter = Builders<Vehicles>.Filter.Eq("_id", oldvVehicle._id);
                return collection.ReplaceOneAsync(filter, oldvVehicle, new ReplaceOptions { IsUpsert = true });
            }
            catch (Exception ex)
            {
                return null;
            }



            }

        public void DeleteVehicle(Vehicles vehicle)
        {
            try
            {
                var collection = ConnectMongo<Vehicles>(VehiclesCollection);
                var filter = Builders<Vehicles>.Filter.Eq("_id", vehicle._id);
                collection.DeleteOneAsync(filter);
            }
            catch (Exception ex)
            {
                
            }



        }





        // order
        public async Task<List<Order>> GetAllOrders()
        {
            try
            {
                var collection = ConnectMongo<Order>(OrdersCollection);
                return await collection.Find(
                    _ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public  Task AddNewOrder(Order order)
        {
            try
            {
                var collection = ConnectMongo<Order>(OrdersCollection);
               return collection.InsertOneAsync(order);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Task UpdateOrder(Order oldOrder)
        {
            try
            {
                var collection = ConnectMongo<Order>(OrdersCollection);
                var filter = Builders<Order>.Filter.Eq("_id", oldOrder._id);
                return collection.ReplaceOneAsync(filter, oldOrder, new ReplaceOptions { IsUpsert = true });
            }
            catch (Exception ex)
            {
                return null;
            }


        }
        }
    }

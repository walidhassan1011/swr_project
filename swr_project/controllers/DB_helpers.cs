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



        private IMongoCollection<T> ConnectMongo<T>(in string collection)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(dbName);
            return database.GetCollection<T>(collection);


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
            try
            {
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
        public async void AddNewUser(User user)
        {
            try
            {
                var collection = ConnectMongo<User>(usersCollection);

                var filter = Builders<User>.Filter.Eq("Email", user.Email);

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
            catch (Exception e)
            {
                MessageBox.Show("something wrong");


            }
        }

        public void UpdateUser(Customer User)
        {
            try
            {

                var collection = ConnectMongo<Customer>(usersCollection);
                var filter = Builders<Customer>.Filter.Eq("_id", User._id);
                collection.ReplaceOneAsync(filter, User, new ReplaceOptions { IsUpsert = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("something wrong");
            }
        }
        public Customer FindUserById(string Id)
        {

            try
            {
                var collection = ConnectMongo<Customer>(usersCollection);
                var filter = Builders<Customer>.Filter.Eq("_id", Id);
                return collection.Find(filter).FirstOrDefaultAsync().Result;
            }
            catch (Exception ex)
            {

                return null;
            }

        }
        public Admin FindUser(string name, string Password)
        {


            var collection = ConnectMongo<Admin>(usersCollection);
            var filter = Builders<Admin>.Filter.Eq("firstName", name);
            var user = collection.Find(filter).FirstOrDefault();
            if (user == null)
            {
                return null;
            }
            else
            {
                if (user.type == "customer"|| user.type=="Customer")
                {
                    MessageBox.Show("Not allowed To Login");
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


        }

        public List<Customer> GetAllUsers()
        {
            var collection = ConnectMongo<Customer>(usersCollection);
            var filter = Builders<Customer>.Filter.Eq("type", "Customer");
            var result = collection.Find(filter).ToList();

            return result;
        }
        public List<Employee> GetAllEmployee()
        {
            var collection = ConnectMongo<Employee>(usersCollection);

            // filter with type = employee && type = admin

            var filter = Builders<Employee>.Filter.Eq("type", "Employee") | Builders<Employee>.Filter.Eq("type", "Admin") | Builders<Employee>.Filter.Eq("type", "admin") | Builders<Employee>.Filter.Eq("type", "employee");

            var result = collection.Find(filter).ToList();

            return result;
        }
        public void DeleteUser(string Id)
        {
            try
            {
                var collection = ConnectMongo<User>(usersCollection);

                if (collection.DeleteOneAsync(c => c._id == Id).Result.DeletedCount == 1)
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
                MessageBox.Show("something wrong");
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


                return null;
            }

        }

        public Task AddNewVehicle(Vehicles vehicle)
        {
            try
            {
                var collection = ConnectMongo<Vehicles>(VehiclesCollection);
                return collection.InsertOneAsync(vehicle);
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public Vehicles FindVehicleById(string Id)
        {
            try
            {
                var collection = ConnectMongo<Vehicles>(VehiclesCollection);
                var filter = Builders<Vehicles>.Filter.Eq("_id", Id);
                return collection.Find(filter).FirstOrDefaultAsync().Result;
            }
            catch (Exception ex)
            {

                return null;
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

        public void DeleteVehicle(string VehicleId)
        {
            try
            {
                var collection = ConnectMongo<Vehicles>(VehiclesCollection);
                if(collection.DeleteOneAsync(c => c._id == VehicleId).Result.DeletedCount == 1)
               
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
                MessageBox.Show("something wrong");
            }



        }

        public List<Vehicles> viewAllVehicles()
        {
            var collection = ConnectMongo<Vehicles>(VehiclesCollection);
            var result = collection.FindAsync(_ => true);
            return result.Result.ToList();


        }





        // order
        public List<Order> GetAllOrders()
        {
            try
            {
                var collection = ConnectMongo<Order>(OrdersCollection);
                var result = collection.FindAsync(_ => true);
                return result.Result.ToList();
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public Task AddNewOrder(Order order)
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

        public Order FindOrderById(string Id)
        {
            try
            {
                var collection = ConnectMongo<Order>(OrdersCollection);
                var filter = Builders<Order>.Filter.Eq("_id", Id);
                return collection.Find(filter).FirstOrDefaultAsync().Result;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public void DeleteOrder(string OrderId)
        {
            try
            {
                var collection = ConnectMongo<Order>(OrdersCollection);
               if (collection.DeleteOneAsync(c => c._id == OrderId).Result.DeletedCount == 1)
                
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
                MessageBox.Show("something wrong");
            }
        }
    }
       
    }

using MongoDB.Driver;
using System;
using System.Configuration;

namespace AddressBook.Models
{
    public class MongoRepository
    {
        private IMongoClient _client;
        private IMongoDatabase _database;

        public MongoRepository()
        {
            try
            {
                // take connection string
                string connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString;
                var connection = new MongoUrlBuilder(connectionString);
                // create mongo client
                _client = new MongoClient(connectionString);
                // take database name from connection string
                _database = _client.GetDatabase(connection.DatabaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Can not access to MongoDb server: " + ex.Message, ex);
            }
        }

        public IMongoCollection<Contact> Contacts => _database.GetCollection<Contact>("contacts");
    }
}
using MongoDB.Driver;

namespace ContactServiceLibrary.MongoService
{
    public class MongoContext
    {
        private IMongoClient _client;
        private IMongoDatabase _database;

        public MongoContext()
        {
            
            // take connection string
            string connectionString = @"mongodb://addressBook:pa55word@localhost/addressBook";
            var connection = new MongoUrlBuilder(connectionString);
            // create mongo client
            _client = new MongoClient(connectionString);
            // take database name from connection string
            _database = _client.GetDatabase(connection.DatabaseName);
        }

        public IMongoCollection<MongoContactType> Contacts => _database.GetCollection<MongoContactType>("contacts");
    }
}

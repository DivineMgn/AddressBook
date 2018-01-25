using ContactServiceLibrary.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace ContactServiceLibrary.MongoService
{
    public class MongoContactService : IContactService<MongoContactType, string>
    {
        MongoContext _context;

        public MongoContactService()
        {
            _context = new MongoContext();
        }

        public string CreateContact(MongoContactType contact)
        {
            _context.Contacts.InsertOne(contact);
            return contact.Id;
        }

        public void DeleteContact(string Id)
        {
            var filter = Builders<MongoContactType>.Filter.Eq(c => new ObjectId(c.Id), new ObjectId(Id));
            _context.Contacts.DeleteOne(filter);
        }

        public IEnumerable<MongoContactType> GetAllContacts()
        {
            var filter = (new FilterDefinitionBuilder<MongoContactType>()).Empty;
            return _context.Contacts.Find(filter).ToList();
        }
    }
}

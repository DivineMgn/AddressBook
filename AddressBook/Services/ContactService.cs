using AddressBook.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    public class ContactService : IContactService
    {
        private readonly MongoRepository _repository;

        public ContactService()
        {
            _repository = new MongoRepository();
        }

        public async Task<IEnumerable<Contact>> GetAllContactsAsync()
        {
            // simple empty filter
            var filter = (new FilterDefinitionBuilder<Contact>()).Empty;
            return await _repository.Contacts.Find(filter).ToListAsync();
        }

        public async Task AddContactAsync(Contact contact)
        {
            // inserting data
            await _repository.Contacts.InsertOneAsync(contact);
        }

        public async Task<bool> RemoveContactAsync(string id)
        {
            var filter = Builders<Contact>.Filter.Eq("id", id);
            var result = await _repository.Contacts.DeleteOneAsync(filter);
            return result.DeletedCount != 0;
        }
    }
}
using AddressBook.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    public interface IContactService
    {
        Task<IEnumerable<Contact>> GetAllContactsAsync();
        Task AddContactAsync(Contact contact);
        Task<bool> RemoveContactAsync(string id);
    }
}
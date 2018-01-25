using ContactServiceLibrary.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ContactServiceLibrary.MsSQLService
{
    public class MsSQLContactService : IContactService<MsSQLContactType, long>
    {
        MsSQLContext _context;

        public MsSQLContactService()
        {
            _context = new MsSQLContext();
        }

        public long CreateContact(MsSQLContactType contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return contact.Id;
        }

        public void DeleteContact(long Id)
        {
            var contact = _context.Contacts.Find(Id);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                _context.SaveChanges();
            }
        }

        public IEnumerable<MsSQLContactType> GetAllContacts()
        {
            var contacts = _context.Contacts.ToList();
            return contacts;
        }
    }
}

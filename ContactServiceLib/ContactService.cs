using System.Collections.Generic;
using System.Linq;

namespace ContactServiceLib
{
    public class ContactService : IContactService
    {
        private MsSQLContext _context;

        public ContactService()
        {
            _context = new MsSQLContext();
        }

        public long CreateContact(ContactDto contact)
        {
            // TODO: AutoMapper
            var newContact = _context.Contacts.Add(
                new Contact()
                {
                    FirstName = contact.FirstName,
                    LastName = contact.LastName,
                    SecondName = contact.SecondName,
                    Email = contact.Email
                });
            _context.Contacts.Add(newContact);
            _context.SaveChanges();

            return newContact.Id;
        }

        public ContactDto GetContactDetails(long id)
        {
            var contact = _context.Contacts.Where(c => c.Id == id).FirstOrDefault();

            if (contact != null)
            {
                // TODO: AutoMapper
                return new ContactDto()
                {
                    Id = contact.Id,
                    FirstName = contact.FirstName,
                    LastName = contact.LastName,
                    SecondName = contact.SecondName,
                    Email = contact.Email
                };
            }

            return null;
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

        public IEnumerable<ContactDto> GetAllContacts()
        {
            // TODO: AutoMapper
            var contacts = _context.Contacts.Select(c => new ContactDto
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                SecondName = c.SecondName,
                Email = c.Email
            });

            return contacts;
        }
    }
}

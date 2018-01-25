using AddressBook.ContactServiceReference;
using AddressBook.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace AddressBook.Controllers
{
    public class ContactController : Controller
    {
        private readonly  IContactService _contactService; 

        public ContactController(IContactService contactService)
        {
            _contactService = contactService; 
        }


        public async Task<ActionResult> Index()
        { 
            var dtoContacts = await _contactService.GetAllContactsAsync();
            
            // TODO: AutoMapper
            var contacts = dtoContacts.Cast<ContactDto>().Select(c =>new Contact() {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                SecondName = c.SecondName,
                Email = c.Email
            });

            return View(contacts);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                // TODO: AutoMapper
                var contactId = await _contactService.CreateContactAsync(new ContactDto()
                {
                    FirstName = contact.FirstName,
                    LastName = contact.LastName,
                    SecondName = contact.SecondName,
                    Email = contact.Email
                }); 

                return RedirectToAction(nameof(this.Index));
            }

            return View(contact);
        }


        [HttpPost]
        public async Task<ActionResult> Delete(long id)
        {
            if (id > 0)
            {
                await _contactService.DeleteContactAsync(id);
            } 

            return RedirectToAction(nameof(this.Index));
        }
    }
}
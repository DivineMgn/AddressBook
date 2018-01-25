using AddressBook.Models;
using AddressBook.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
 

namespace AddressBook.Controllers
{
    public class ContactController : Controller
    {

        private readonly IContactService _contactService;
        private readonly AddressBookDBContext _context;


        public ContactController(IContactService contactService)
        {
 

            _contactService = contactService;
            _context = new AddressBookDBContext();
        }


        public async Task<ActionResult> Index()
        {
            // mongo
            //var contacts = await _contactService.GetAllContactsAsync();

            var contacts = await _context.Contacts.ToListAsync();

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
                // mongo
                //await _contactService.AddContactAsync(contact);
                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(this.Index));
            }

            return View(contact);
        }


        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            // mongo
            //var isDeleted = await _contactService.RemoveContactAsync(mongoId);

            var contact = await _context.Contacts.FindAsync(id);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(this.Index));
        }
    }
}
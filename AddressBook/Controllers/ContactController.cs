using AddressBook.Models;
using AddressBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AddressBook.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }


        public async Task<ActionResult> Index()
        {
            var contacts = await _contactService.GetAllContactsAsync();
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
                await _contactService.AddContactAsync(contact);
                return RedirectToAction(nameof(this.Index));
            }

            return View(contact);
        }


        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            var isDeleted = await _contactService.RemoveContactAsync(id);
            return RedirectToAction(nameof(this.Index));
        }
    }
}
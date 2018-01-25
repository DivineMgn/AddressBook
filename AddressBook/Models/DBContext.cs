using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AddressBook.Models
{
    public class AddressBookDBContext : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }

        public AddressBookDBContext() : base("MsSQL") { }
    }
}
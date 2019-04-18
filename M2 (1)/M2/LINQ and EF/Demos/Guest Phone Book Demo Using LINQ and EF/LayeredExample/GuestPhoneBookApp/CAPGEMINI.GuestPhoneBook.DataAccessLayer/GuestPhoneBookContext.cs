using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPGEMINI.GuestPhoneBook.Entities;

namespace CAPGEMINI.GuestPhoneBook.DataAccessLayer
{
    class GuestPhoneBookContext:DbContext
    {
        public GuestPhoneBookContext()
        {}

        public DbSet<Guest> Guests { get; set; }
    }
}

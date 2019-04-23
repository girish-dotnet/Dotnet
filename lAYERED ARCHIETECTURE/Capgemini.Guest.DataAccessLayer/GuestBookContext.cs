using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Capgemini.Guest.Entities;

namespace Capgemini.Guest.DataAccessLayer
{
    class GuestBookContext: DbContext
    {
        public GuestBookContext()
        { }
        public DbSet<GuestBook> Guests { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPGEMINI.GuestPhoneBook.Entities
{
    public class Guest
    {
        public Guest()
        {
            GuestID = 0;
            GuestName = string.Empty;
            GuestContactNumber = string.Empty;
        }

        public int GuestID { get; set; }
        public string GuestName { get; set; }
        public string GuestContactNumber { get; set; }
    }
}

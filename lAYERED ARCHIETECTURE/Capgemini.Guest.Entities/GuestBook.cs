using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.Guest.Entities
{
    public class GuestBook
    {
        public GuestBook()
        {
            GuestID = 0;
            GuestName = string.Empty;
            GuestContactNumber = string.Empty;
        }
        [Key]
        public int GuestID { get; set; }
        public string GuestName { get; set; }
        public string GuestContactNumber { get; set; }
    }
}

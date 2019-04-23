using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Capgemini.Guest.Entities;
using Capgemini.Guest.Exceptions;

namespace Capgemini.Guest.DataAccessLayer
{
    public class GuestDAL
    {
        GuestBookContext context = new GuestBookContext();

        public bool DeleteGuestDAL(int guestID)
        {
            bool guestDeleted = false;
            try
            {
                GuestBook guest = null;
                guest = context.Guests.Where(g => g.GuestID ==guestID).Select(g => g).FirstOrDefault();
                if (guest != null)
                {
                    context.Guests.Remove(guest);
                    int status = context.SaveChanges();
                    if (status > 0)
                    {
                        guestDeleted = true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new GuestException(ex.Message);
            }
            return guestDeleted;
        }

        public bool UpdateGuestDAL(GuestBook guest)
        {
            bool guestupdated = false;
            try
            {
                GuestBook oldGuest = null;
                oldGuest = context.Guests.Where(g => g.GuestID == guest.GuestID).Select(g => g).FirstOrDefault();
                if (oldGuest != null)
                {
                    oldGuest.GuestName = guest.GuestName;
                    oldGuest.GuestContactNumber = guest.GuestContactNumber;
                    int status = context.SaveChanges();
                    if (status > 0)
                    {
                        guestupdated = true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new GuestException(ex.Message);
            }
            return guestupdated;
        }

        public GuestBook SearchGuestDAL(int guestID)
        {
            GuestBook searchedGuest = null;
            try
            {
                searchedGuest = context.Guests.Where(g => 
                    g.GuestID == guestID).Select(g => g).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw new GuestException(ex.Message);
            }
            return searchedGuest;
        }

        public bool AddGuestDAL(GuestBook guest)
        {
            bool guestAdded = false;
            try
            {
                context.Guests.Add(guest);
                int status = context.SaveChanges();

                if (status > 0)
                {
                    guestAdded = true;
                }
            }
            catch (Exception ex)
            {

                throw new GuestException(ex.Message);
            }
            return guestAdded;
        }
        public List<GuestBook> GetAllGuestDAL()
        {
            List<GuestBook> guestList = null;
            try
            {
                guestList = context.Guests.ToList();
            }
            catch (Exception ex)
            {

                throw new GuestException(ex.Message);
            }
            return guestList;
        }        
       
    }
}

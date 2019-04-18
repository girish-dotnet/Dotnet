using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPGEMINI.GuestPhoneBook.Entities;//Namespace for Guest Class
using CAPGEMINI.GuestPhoneBook.Exceptions;//Namespace for using custom exceptions

namespace CAPGEMINI.GuestPhoneBook.DataAccessLayer
{
    public class GuestDAL
    {
        GuestPhoneBookContext guestContext = new GuestPhoneBookContext();

        public List<Guest> GetAllGuestDAL()
        {
            List<Guest> guestList=null;

            try
            {
                guestList = guestContext.Guests.ToList();
            }
            catch(Exception ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }

            return guestList;
        }

        public bool AddGuestDAL(Guest guest)
        {
            bool guestAdded = false;

            try
            {
                guestContext.Guests.Add(guest);
                int status = guestContext.SaveChanges();

                if(status>0)
                {
                    guestAdded=true;
                }
            }
            catch (Exception ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }

            return guestAdded;
        }

        public Guest SearchGuestDAL(int guestID)
        {
            Guest searchedGuest= null;
            
            try
            {
                var guests= (from guest in guestContext.Guests.Where
                                 (guest=>guest.GuestID == guestID)
                                 select guest).FirstOrDefault();

                if(guests!=null)
                {
                    searchedGuest = guests;
                }
            }
            catch(Exception ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }

            return searchedGuest;
        }

        public bool UpdateGuestDAL(Guest guest)
        {
            bool guestUpdated = false;

            try
            {
                var guests = (from g in guestContext.Guests.Where
                                  (g=>g.GuestID == guest.GuestID)
                                  select g).FirstOrDefault();

                if(guests!=null)
                {
                    guests.GuestName= guest.GuestName;
                    guests.GuestContactNumber = guest.GuestContactNumber;

                    int status = guestContext.SaveChanges();
                    if(status >0)
                    {
                        guestUpdated= true;
                    }
                }
            }
            catch(Exception ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }

            return guestUpdated;
        }

        public bool DeleteGuestDAL(int GuestID)
        {
            bool guestDeleted = false;  

            try
            {
                var guests = (from g in guestContext.Guests.Where
                                  (g=>g.GuestID== GuestID)
                                  select g).FirstOrDefault();

                if(guests!=null)
                {
                    guestContext.Guests.Remove(guests);

                    int status = guestContext.SaveChanges();

                    if(status>0)
                    {
                        guestDeleted= true;
                    }
                }
            }
            catch(Exception ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }

            return guestDeleted;
        }
    }
}

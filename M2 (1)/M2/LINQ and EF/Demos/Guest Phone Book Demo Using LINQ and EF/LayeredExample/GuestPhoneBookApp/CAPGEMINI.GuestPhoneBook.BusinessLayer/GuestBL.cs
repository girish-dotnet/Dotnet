using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPGEMINI.GuestPhoneBook.Entities;
using CAPGEMINI.GuestPhoneBook.DataAccessLayer;
using CAPGEMINI.GuestPhoneBook.Exceptions;

namespace CAPGEMINI.GuestPhoneBook.BusinessLayer
{
    public class GuestBL
    {
        

        private static bool ValidateGuest(Guest guest)
        {
            StringBuilder sb = new StringBuilder();

            bool validGuest = true;

            if (guest.GuestName == string.Empty)
            {
                validGuest = false;
                sb.Append(Environment.NewLine + "Guest Name Required");
            }
            if (guest.GuestContactNumber.Length < 10)
            {
                validGuest = false;
                sb.Append(Environment.NewLine + "Required 10 Digit Contact Number");
            }

            if (validGuest == false)
            {
                throw new GuestPhoneBookException(sb.ToString());
            }

            return validGuest;
        }

        public static List<Guest> GetAllGuestBL()
        {
            List<Guest> guestList = null;
            try
            {
                GuestDAL guestDAL = new GuestDAL();
                guestList = guestDAL.GetAllGuestDAL();
            }
            catch (GuestPhoneBookException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guestList;
        }

        public static bool AddGuestBL(Guest guest)
        {
            bool guestAdded = false;

            try
            {
                if (ValidateGuest(guest))
                {
                    GuestDAL guestDAL = new GuestDAL();
                    guestAdded = guestDAL.AddGuestDAL(guest);
                }
            }
            catch (GuestPhoneBookException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guestAdded;
        }

        public static Guest SearchGuestBL(int searchGuestID)
        {
            Guest searchedGuest = null;

            try
            {
                GuestDAL guestDAL = new GuestDAL();
                searchedGuest = guestDAL.SearchGuestDAL(searchGuestID);
            }
            catch (GuestPhoneBookException)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw ex;    
            }

            return searchedGuest;
        }

        public static bool UpdateGuestBL(Guest guest)
        {
            bool guestUpdated = false;

            try
            {
                if (ValidateGuest(guest))
                {
                    GuestDAL guestDAL = new GuestDAL();
                    guestUpdated = guestDAL.UpdateGuestDAL(guest);
                }
            }
            catch (GuestPhoneBookException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;   
            }

            return guestUpdated;
        }

        public static bool DeleteGuestBL(int guestID)
        {
            bool guestDeleted = false;

            try 
            {
                if (guestID > 0)
                {
                    GuestDAL guestDAL = new GuestDAL();
                    guestDeleted = guestDAL.DeleteGuestDAL(guestID);
                }
                else
                {
                    throw new GuestPhoneBookException("Invalid Guest ID");
                }
            }
            catch(GuestPhoneBookException)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return guestDeleted;
        }
    }
}

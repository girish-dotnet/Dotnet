using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capgemini.Guest.DataAccessLayer;
using Capgemini.Guest.Entities;
using Capgemini.Guest.Exceptions;

namespace Capgemini.Guest.BusinessLayer
{
    public class GuestBL
    {

        public static List<GuestBook> GetAllGuestBL()
        {
            List<GuestBook> guestList = null;
            GuestDAL guestDAL = new GuestDAL();
            guestList= guestDAL.GetAllGuestDAL();
            return guestList;

        }

        public static bool UpdateGuestBL(GuestBook guest)
        {
            bool guestUpdated = false;

            try
            {
                if (Validate(guest))
                {
                    GuestDAL guestDAL = new GuestDAL();
                    guestUpdated = guestDAL.UpdateGuestDAL(guest);
                }
            }
            catch (GuestException)
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
                    throw new GuestException("Invalid Guest ID");
                }
            }
            catch (GuestException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guestDeleted;
        }

        public static GuestBook SearchGuestBL(int searchGuestID)
        {
            GuestBook searchedGuest = null;

            try
            {
                GuestDAL guestDAL = new GuestDAL();
                searchedGuest = guestDAL.SearchGuestDAL(searchGuestID);
            }
            catch (GuestException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchedGuest;
        }


        public static bool AddGuestBL(GuestBook guest)
        {
            bool guestAdded = false;

            try
            {
                if (Validate(guest))
                {
                    GuestDAL guestDAL = new GuestDAL();
                    guestAdded = guestDAL.AddGuestDAL(guest);
                }
            }
            catch (GuestException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guestAdded;
        }
        private static bool Validate(GuestBook guest)
        {
            StringBuilder sb = new StringBuilder();

            bool validGuest = true;

            if(guest.GuestName==string.Empty)
            {
                validGuest = false;
                sb.Append(Environment.NewLine + "Guest Name Required");
            }
            if(guest.GuestContactNumber.Length<10)
            {
                validGuest = false;
                sb.Append(Environment.NewLine + "Required 10 Digi Contact Number");
            }
            if(validGuest==false)
            {
                throw new GuestException(sb.ToString());
            }
            return validGuest;
        }
    }
}

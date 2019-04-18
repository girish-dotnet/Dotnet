using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using Entities;
using System.Data;
using Exceptions;

namespace DAL
{
    public class GuestDAL
    {
        public bool AddGuestDAL(Guest newGuest)
        {
            bool guestAdded = false;
            try
            {
                DbCommand command = DataConnection.CreateCommand();
                command.CommandText = "uspAddGuest";

                DbParameter param = command.CreateParameter();
                param.ParameterName = "@ipv_iGuestID";
                param.DbType = DbType.Int32;
                param.Value = newGuest.GuestID;
                command.Parameters.Add(param);


                param = command.CreateParameter();
                param.ParameterName = "@ipv_vcGuestName";
                param.DbType = DbType.String;
                param.Value = newGuest.GuestName;
                command.Parameters.Add(param);


                param = command.CreateParameter();
                param.ParameterName = "@ipv_vcGuestContactNumber";
                param.DbType = DbType.String;
                param.Value = newGuest.GuestContactNumber;
                command.Parameters.Add(param);

                int affectedRows = DataConnection.ExecuteNonQueryCommand(command);

                if (affectedRows > 0)
                    guestAdded = true;
            }
            catch (DbException ex)
            {
                string errormessage;
                
                switch (ex.ErrorCode)
                {
                    case -2146232060:
                        errormessage = "Database Does NotExists Or AccessDenied";
                        break;
                    default:
                       errormessage = ex.Message;
                        break;
                }
                throw new GuestPhoneBookException(errormessage);
            }
            return guestAdded;

        }

        public List<Guest> GetAllGuestsDAL()
        {
            List<Guest> guestList = null;
            try
            {
                DbCommand command = DataConnection.CreateCommand();
                command.CommandText = "uspGetAllGuests";



                DataTable dataTable = DataConnection.ExecuteSelectCommand(command);
                if (dataTable.Rows.Count > 0)
                {
                    guestList = new List<Guest>();
                    for (int rowCounter = 0; rowCounter < dataTable.Rows.Count; rowCounter++)
                    {
                        Guest guest = new Guest();
                        guest.GuestID = (int)dataTable.Rows[rowCounter][0];
                        guest.GuestName = (string)dataTable.Rows[rowCounter][1];
                        guest.GuestContactNumber = (string)dataTable.Rows[rowCounter][2];
                        guestList.Add(guest);
                    }
                }
            }
            catch (DbException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return guestList;
        }

        public Guest SearchGuestDAL(int searchGuestID)
        {
            Guest searchGuest = null;
            try
            {
                DbCommand command = DataConnection.CreateCommand();
                command.CommandText = "uspSearchGuest";

                DbParameter param = command.CreateParameter();
                param.ParameterName = "@ipv_iGuestID";
                param.DbType = DbType.Int32;
                param.Value = searchGuestID;
                command.Parameters.Add(param);

                DataTable dataTable = DataConnection.ExecuteSelectCommand(command);
                if (dataTable.Rows.Count > 0)
                {
                    searchGuest = new Guest();
                    searchGuest.GuestID = (int)dataTable.Rows[0][0];
                    searchGuest.GuestName = (string)dataTable.Rows[0][1];
                    searchGuest.GuestContactNumber = (string)dataTable.Rows[0][2];

                }
            }
            catch (DbException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return searchGuest;
        }

        public bool UpdateGuestDAL(Guest updateGuest)
        {
            bool guestUpdated = false;
            try
            {
                DbCommand command = DataConnection.CreateCommand();
                command.CommandText = "uspUpdateGuest";

                DbParameter param = command.CreateParameter();
                param.ParameterName = "@ipv_iGuestID";
                param.DbType = DbType.Int32;
                param.Value = updateGuest.GuestID;
                command.Parameters.Add(param);


                param = command.CreateParameter();
                param.ParameterName = "@ipv_vcGuestName";
                param.DbType = DbType.String;
                param.Value = updateGuest.GuestName;
                command.Parameters.Add(param);


                param = command.CreateParameter();
                param.ParameterName = "@ipv_vcGuestContactNumber";
                param.DbType = DbType.String;
                param.Value = updateGuest.GuestContactNumber;
                command.Parameters.Add(param);

                int affectedRows = DataConnection.ExecuteNonQueryCommand(command);

                if (affectedRows > 0)
                    guestUpdated = true;
            }
            catch (DbException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return guestUpdated;

        }

        public bool DeleteGuestDAL(int deleteGuestID)
        {
            bool guestDeleted = false;
            try
            {
                DbCommand command = DataConnection.CreateCommand();
                command.CommandText = "uspDeleteGuest";

                DbParameter param = command.CreateParameter();
                param.ParameterName = "@ipv_iGuestID";
                param.DbType = DbType.Int32;
                param.Value = deleteGuestID;
                command.Parameters.Add(param);

                int affectedRows = DataConnection.ExecuteNonQueryCommand(command);

                if (affectedRows > 0)
                    guestDeleted = true;
            }
            catch (DbException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return guestDeleted;

        }

    }
}
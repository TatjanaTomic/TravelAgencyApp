using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data.DataAccess.Exceptions;
using TravelAgency.Data.Model;

namespace TravelAgency.Data.DataAccess.MySql
{
    public class MySqlReservation : IReservation
    {
        private static readonly string SELECT = @"SELECT * FROM rezervacije_detaljno WHERE Ime LIKE @str or Prezime LIKE @str or JMB LIKE @str or Naziv LIKE @str";
        private static readonly string INSERT = @"INSERT INTO rezervacija values (sysdate(), @managerID, @travellerID, @offerID);";
        private static readonly string DELETE = @"DELETE FROM rezervacija WHERE Putnik=@travellerID and Ponuda=@offerID";

        public List<Reservation> GetReservations(string filter)
        {
            List<Reservation> result = new List<Reservation>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                cmd.Parameters.AddWithValue("@str", "%" + filter + "%");
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Reservation()
                    {
                        DateOfReservation = reader.GetDateTime(0),
                        Manager = new Employee()
                        {
                            Id = reader.GetInt32(1),
                        },
                        Traveller = new Traveller()
                        {
                            Id = reader.GetInt32(2),
                            FirstName = reader.GetString(3),
                            LastName = reader.GetString(4),
                            Jmb = reader.GetString(5)
                        },
                        Offer = new Offer()
                        {
                            Id = reader.GetInt32(6),
                            Name = reader.GetString(7)
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlReservation", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
        public void InsertReservation(int managerID, int travellerID, int offerID)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@managerID", managerID);
                cmd.Parameters.AddWithValue("@travellerID", travellerID);
                cmd.Parameters.AddWithValue("@offerID", offerID); 
                cmd.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlReservation", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }
        public void DeleteReservation(int travellerID, int offerID)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@travellerID", travellerID);
                cmd.Parameters.AddWithValue("@offerID", offerID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlReservation", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }
    }
}

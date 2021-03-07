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
    public class MySqlReceipt : IReceipt
    {
        private static readonly string SELECT = @"SELECT k.Id, DatumIzdavanja, IdPutnika, Ime, Prezime, JMB, IdPonude, Naziv, RedniBrojAutobusa, BrojSjedista 
                                                  from (rezervacije_detaljno r inner join karta k on r.IdPutnika=k.Putnik and r.IdPonude=k.Ponuda) 
                                                  WHERE Ime LIKE @str or Prezime LIKE @str or JMB LIKE @str or Naziv LIKE @str";
        private static readonly string INSERT = @"INSERT INTO karta values (null, sysdate(), @offerID, @travellerID, @NumberOfBus, @NumberOfSeat)";
        private static readonly string UPDATE = @"UPDATE karta SET 
                                                        RedniBrojAutobusa=@NumberOfBus,
                                                        BrojSjedista=@SeatNumber
                                                  where Id=@Id;";
        private static readonly string DELETE = @"DELETE FROM karta WHERE Id=@Id;";
        private static readonly string FIND = @"SELECT count(*) from karta where Putnik=@traveller and Ponuda=@offer;";
        private static readonly string CHECK_SEAT = @"select count(*) from karta where Ponuda=@offer and RedniBrojAutobusa=@bus and BrojSjedista=@seat;";
        
        List<Receipt> IReceipt.GetReceipts(string filter)
        {
            List<Receipt> result = new List<Receipt>();
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
                    result.Add(new Receipt()
                    {
                        Id = reader.GetInt32(0),
                        DateOfCreation = reader.GetDateTime(1),
                        Offer = new Offer()
                        {
                            Id = reader.GetInt32(6),
                            Name = reader.GetString(7)
                        },
                        Traveller = new Traveller()
                        {
                            Id = reader.GetInt32(2),
                            FirstName = reader.GetString(3),
                            LastName = reader.GetString(4),
                            Jmb = reader.GetString(5)
                        },
                        NumberOfBus = reader.GetInt32(8),
                        NumberOfSeat = reader.GetInt32(9)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlReceipt", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        void IReceipt.DeleteReceipt(int id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlReceipt", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }

        void IReceipt.InsertReceipt(Receipt r)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@offerID", r.Offer.Id);
                cmd.Parameters.AddWithValue("@travellerID", r.Traveller.Id);
                cmd.Parameters.AddWithValue("@NumberOfBus", r.NumberOfBus);
                cmd.Parameters.AddWithValue("@NumberOfSeat", r.NumberOfSeat);
                cmd.ExecuteNonQuery();
                r.Id = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlReceipt", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }

        void IReceipt.UpdateReceipt(Receipt r)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@NumberOfBus", r.NumberOfBus);
                cmd.Parameters.AddWithValue("@SeatNumber", r.NumberOfSeat);
                cmd.Parameters.AddWithValue("@Id", r.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlReceipt", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }

        int IReceipt.CheckIfExists(int offer, int traveller)
        {
            int result = -1;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = FIND;
                cmd.Parameters.AddWithValue("@traveller", traveller);
                cmd.Parameters.AddWithValue("@offer", offer);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                    result = reader.GetInt32(0) == 0 ? 0 : 1;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlReceipt", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        int IReceipt.CheckSeat(Receipt r)
        {
            int result = -1;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = CHECK_SEAT;
                cmd.Parameters.AddWithValue("@offer", r.Offer.Id);
                cmd.Parameters.AddWithValue("@bus", r.NumberOfBus);
                cmd.Parameters.AddWithValue("@seat", r.NumberOfSeat);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                    result = reader.GetInt32(0) == 0 ? 0 : 1;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlReceipt", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
    }
}

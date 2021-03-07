using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data.DataAccess.Exceptions;
using TravelAgency.Data.Model;

namespace TravelAgency.Data.DataAccess.MySql
{
    public class MySqlTrip : ITrip
    {
        private static readonly string SELECT = @"SELECT * FROM izlet_detaljno WHERE Naziv LIKE @str;";
        private static readonly string INSERT_PRICE = "INSERT into cijena values (null, @prevoz, 0, @osiguranje, @taksa, null);";
        private static readonly string INSERT_OFFER = "INSERT into ponuda values (null, @naziv, @komercijalista, @cijena, sysdate());";
        private static readonly string INSERT_TRIP = "INSERT into izlet values (@id, @datum, @polazak, @povratak);";
        private static readonly string UPDATE_PRICE = @"UPDATE cijena SET
                                                                TroskoviPrevoza=@prevoz,
                                                                CijenaOsiguranja=@osiguranje,
                                                                BoravisnaTaksa=@taksa
                                                            where Id=@Id;";
        private static readonly string UPDATE_OFFER = @"UPDATE ponuda SET Naziv=@naziv where Id=@Id;";
        private static readonly string UPDATE_TRIP = @"UPDATE izlet SET Datum=@datum, VrijemePolaska=@polazak, VrijemePovratka=@povratak where IdPonude=@Id;";
        public List<Trip> GetTrips(string filter)
        {
            List<Trip> result = new List<Trip>();
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
                    decimal _travelInsurance = reader.IsDBNull(9) ? (decimal)0.0 : reader.GetDecimal(9);
                    decimal _touristTax = reader.IsDBNull(10) ? (decimal)0.0 : reader.GetDecimal(10);

                    result.Add(new Trip()
                    {
                        Offer = new Offer()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            DateOfCreation = reader.GetDateTime(6),
                            Commercialist = new Employee()
                            {
                                Id = reader.GetInt32(5)
                            },
                            Price = new Price ()
                            {
                                Id = reader.GetInt32(7),
                                TransportCost = reader.GetDecimal(8),
                                TravelInsurance = _travelInsurance,
                                TouristTax = _touristTax,
                                TotalPrice = reader.GetDecimal(11)
                            }
                        },
                        Date = reader.GetDateTime(2),
                        TimeDeparture = reader.GetTimeSpan(3),
                        TimeReturn = reader.GetTimeSpan(4)
                    }) ;
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTrip", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
        public void DeleteTripById(int id, int priceId)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "obrisi_izlet";
                cmd.Parameters.AddWithValue("@pId", id);
                cmd.Parameters["@pId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@cId", priceId);
                cmd.Parameters["@cId"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTrip", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
        public void InsertTrip(Trip t)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_PRICE;
                cmd.Parameters.AddWithValue("@prevoz", t.Offer.Price.TransportCost);
                cmd.Parameters.AddWithValue("@osiguranje", t.Offer.Price.TravelInsurance);
                cmd.Parameters.AddWithValue("@taksa", t.Offer.Price.TouristTax);
                cmd.ExecuteNonQuery();
                t.Offer.Price.Id = (int)cmd.LastInsertedId;

                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_OFFER;
                cmd.Parameters.AddWithValue("@naziv", t.Offer.Name);
                cmd.Parameters.AddWithValue("@komercijalista", t.Offer.Commercialist.Id);
                cmd.Parameters.AddWithValue("@cijena", t.Offer.Price.Id);
                cmd.ExecuteNonQuery();
                t.Offer.Id = (int)cmd.LastInsertedId;

                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_TRIP;
                cmd.Parameters.AddWithValue("@id", t.Offer.Id);
                cmd.Parameters.AddWithValue("@datum", t.Date);
                cmd.Parameters.AddWithValue("@polazak", t.TimeDeparture);
                cmd.Parameters.AddWithValue("@povratak", t.TimeReturn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTrip", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }

        public void UpdateTrip(Trip t)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_PRICE;
                cmd.Parameters.AddWithValue("@prevoz", t.Offer.Price.TransportCost);
                cmd.Parameters.AddWithValue("@osiguranje", t.Offer.Price.TravelInsurance);
                cmd.Parameters.AddWithValue("@taksa", t.Offer.Price.TouristTax);
                cmd.Parameters.AddWithValue("@Id", t.Offer.Price.Id);
                cmd.ExecuteNonQuery();

                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_OFFER;
                cmd.Parameters.AddWithValue("@naziv", t.Offer.Name);
                cmd.Parameters.AddWithValue("@Id", t.Offer.Id);
                cmd.ExecuteNonQuery();

                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_TRIP;
                cmd.Parameters.AddWithValue("@id", t.Offer.Id);
                cmd.Parameters.AddWithValue("@datum", t.Date);
                cmd.Parameters.AddWithValue("@polazak", t.TimeDeparture);
                cmd.Parameters.AddWithValue("@povratak", t.TimeReturn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTrip", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }
    }
}

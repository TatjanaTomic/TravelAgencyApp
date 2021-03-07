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
    public class MySqlTravel : ITravel
    {
        private static readonly string SELECT = @"SELECT * FROM putovanja_detaljno WHERE Naziv LIKE @str;";
        private static readonly string INSERT_PRICE = "INSERT into cijena values (null, @prevoz, @smjestaj, @osiguranje, @taksa, null);";
        private static readonly string INSERT_OFFER = "INSERT into ponuda values (null, @naziv, @komercijalista, @cijena, sysdate());";
        private static readonly string INSERT_TRIP = "INSERT into putovanje values (@id, @polazak, @povratak);";
        private static readonly string UPDATE_PRICE = @"UPDATE cijena SET
                                                                TroskoviPrevoza=@prevoz,
                                                                CijenaSmjestaja=@smjestaj,
                                                                CijenaOsiguranja=@osiguranje,
                                                                BoravisnaTaksa=@taksa
                                                            where Id=@Id;";
        private static readonly string UPDATE_OFFER = @"UPDATE ponuda SET Naziv=@naziv where Id=@Id;";
        private static readonly string UPDATE_TRAVEL = @"UPDATE putovanje SET Polazak=@polazak, Povratak=@povratak where IdPonude=@Id;";

        public List<Travel> GetTravels(string filter)
        {
            List<Travel> result = new List<Travel>();
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
                    decimal _accomodation = reader.IsDBNull(8) ? (decimal)0.0 : reader.GetDecimal(8);
                    decimal _travelInsurance = reader.IsDBNull(9) ? (decimal)0.0 : reader.GetDecimal(9);
                    decimal _touristTax = reader.IsDBNull(10) ? (decimal)0.0 : reader.GetDecimal(10);

                    result.Add(new Travel()
                    {
                        Offer = new Offer()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            DateOfCreation = reader.GetDateTime(5),
                            Commercialist = new Employee()
                            {
                                Id = reader.GetInt32(4)
                            },
                            Price = new Price()
                            {
                                Id = reader.GetInt32(6),
                                TransportCost = reader.GetDecimal(7),
                                Accommodation = _accomodation,
                                TravelInsurance = _travelInsurance,
                                TouristTax = _touristTax,
                                TotalPrice = reader.GetDecimal(11)
                            }
                        },
                        Departure = reader.GetDateTime(2),
                        Return = reader.GetDateTime(3)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTravel", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
        public void DeleteTravelById(int id, int priceId)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "obrisi_putovanje";
                cmd.Parameters.AddWithValue("@pId", id);
                cmd.Parameters["@pId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@cId", priceId);
                cmd.Parameters["@cId"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTravel", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
        public void InsertTravel(Travel t)
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
                cmd.Parameters.AddWithValue("smjestaj", t.Offer.Price.Accommodation);
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
                cmd.Parameters.AddWithValue("@polazak", t.Departure);
                cmd.Parameters.AddWithValue("@povratak", t.Return);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTravel", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }
        public void UpdateTravel(Travel t)
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
                cmd.Parameters.AddWithValue("smjestaj", t.Offer.Price.Accommodation);
                cmd.Parameters.AddWithValue("@osiguranje", t.Offer.Price.TravelInsurance);
                cmd.Parameters.AddWithValue("@taksa", t.Offer.Price.TouristTax);
                cmd.Parameters.AddWithValue("@Id", t.Offer.Id);
                cmd.ExecuteNonQuery();

                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_OFFER;
                cmd.Parameters.AddWithValue("@naziv", t.Offer.Name);
                cmd.Parameters.AddWithValue("@Id", t.Offer.Id);
                cmd.ExecuteNonQuery();

                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_TRAVEL;
                cmd.Parameters.AddWithValue("@id", t.Offer.Id);
                cmd.Parameters.AddWithValue("@polazak", t.Departure);
                cmd.Parameters.AddWithValue("@povratak", t.Return);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTravel", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }
    }
}
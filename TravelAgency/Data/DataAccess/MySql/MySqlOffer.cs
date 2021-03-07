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
    public class MySqlOffer : IOffer
    {
        private static readonly string SELECT = @"SELECT * FROM ponude_detaljno WHERE Naziv LIKE @str or Ime LIKE @str or Prezime LIKE @str;";
        private static readonly string COUNT_RESERVATIONS = @"select count(*) from rezervacija r inner join ponuda p on p.Id=r.Ponuda where p.Id=@Id;";
        private static readonly string ACTIVE_OFFERS = @"select Id, Naziv from (ponuda p inner join izlet i on p.Id=i.IdPonude) where Datum>sysdate()
                                                         union 
                                                         select Id, Naziv from (ponuda p inner join putovanje t on p.Id=t.IdPonude) where Polazak>sysdate();";
        public List<(Offer, int, int)> GetOffers(string filter)
        {
            List<(Offer, int, int)> result = new List<(Offer, int, int)>();
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
                    result.Add((new Offer()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        DateOfCreation = reader.GetDateTime(2),
                        Commercialist = new Employee()
                        {
                            Id = reader.GetInt32(3),
                            FirstName = reader.GetString(4),
                            LastName = reader.GetString(5),
                        },
                        Price = new Price()
                        {
                            Id = reader.GetInt32(6),
                            TotalPrice = reader.GetDecimal(7)
                        }
                    },
                    reader.GetInt32(8),
                    reader.GetInt32(9)));
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlOffer", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public int CountReservations(int id)
        {
            int result = -1;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = COUNT_RESERVATIONS;
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                    result = reader.GetInt32(0);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlOffer", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public List<Offer> GetActiveOffers(string filter)
        {
            List<Offer> result = new List<Offer>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = ACTIVE_OFFERS;
                cmd.Parameters.AddWithValue("@str", "%" + filter + "%");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Offer()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlOffer", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
    }
}

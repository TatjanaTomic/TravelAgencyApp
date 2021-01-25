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
    public class MySqlOffer : IOffer
    {
        private static readonly string SELECT = @"SELECT * FROM ponude_detaljno;";
        public List<Offer> GetOffers()
        {
            List<Offer> result = new List<Offer>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Offer()
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

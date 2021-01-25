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
    public class MySqlTrip : ITrip
    {
        private static readonly string SELECT = @"SELECT * FROM izlet_detaljno;";
        public List<Trip> GetTrips()
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
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
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
                                TotalPrice = reader.GetDecimal(8)
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

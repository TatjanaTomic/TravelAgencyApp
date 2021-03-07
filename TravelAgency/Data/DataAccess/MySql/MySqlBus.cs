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
    public class MySqlBus : IBus
    {
        private static readonly string SELECT = @"SELECT * FROM autobus WHERE
                                                     RegistarskiBroj LIKE @str or 
                                                     Proizvodjac LIKE @str or 
                                                     Model LIKE @str or 
                                                     BrojSjedista LIKE @str;";
        private static readonly string INSERT = @"INSERT INTO autobus(RegistarskiBroj, Proizvodjac, Model, BrojSjedista)
                                                     VALUES (@LicensePlate, @Manufacturer, @Model, @NumberOfSeats);";
        private static readonly string UPDATE = @"UPDATE autobus SET 
                                                     Proizvodjac=@Manufacturer,
                                                     Model=@Model,
                                                     BrojSjedista=@NumberOfSeats
                                                  where RegistarskiBroj=@LicensePlate;";
        private static readonly string DELETE = @"DELETE FROM autobus WHERE RegistarskiBroj=@LicensePlate;";

        public List<Bus> GetBuses(string filter)
        {
            List<Bus> result = new List<Bus>();
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
                    result.Add(new Bus()
                    {
                        LicensePlate = reader.GetString(0),
                        Manufacturer = reader.GetString(1),
                        Model = reader.GetString(2),
                        NumberOfSeats = reader.GetInt32(3),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBus", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void InsertBus(Bus b)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@LicensePlate", b.LicensePlate);
                cmd.Parameters.AddWithValue("@Manufacturer", b.Manufacturer);
                cmd.Parameters.AddWithValue("@Model", b.Model);
                cmd.Parameters.AddWithValue("@NumberOfSeats", b.NumberOfSeats);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBus", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }

        public void UpdateBus(Bus b)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@LicensePlate", b.LicensePlate);
                cmd.Parameters.AddWithValue("@Manufacturer", b.Manufacturer);
                cmd.Parameters.AddWithValue("@Model", b.Model);
                cmd.Parameters.AddWithValue("@NumberOfSeats", b.NumberOfSeats);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBus", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }

        public void DeleteBusByLicensePlate(string lp)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@LicensePlate", lp);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBus", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }
    }
}

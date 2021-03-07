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
    public class MySqlTraveller : ITraveller
    {
        private static readonly string SELECT = @"SELECT * FROM putnik WHERE
                                                     Ime LIKE @str or 
                                                     Prezime LIKE @str or 
                                                     JMB LIKE @str or 
                                                     BrojLicneKarte LIKE @str or 
                                                     BrojPasosa LIKE @str;";
        private static readonly string INSERT = @"INSERT INTO putnik(Ime, Prezime, JMB, BrojLicneKarte, BrojPasosa)
                                                     VALUES (@FirstName, @LastName, @Jmb, @IdCardNumber, @PassportNumber);";
        private static readonly string UPDATE = @"UPDATE putnik SET 
                                                        Ime=@FirstName,
                                                        Prezime=@LastName,
                                                        Jmb=@Jmb,
                                                        BrojLicneKarte=@IdCardNumber,
                                                        BrojPasosa=@PassportNumber
                                                     where Id=@Id;";
        private static readonly string DELETE = @"DELETE FROM putnik WHERE Id=@Id;";

        public List<Traveller> GetTravellers(string filter)
        {
            List<Traveller> result = new List<Traveller>();
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
                    var _idCardNumber = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    var _passportNumber = reader.IsDBNull(5) ? "" : reader.GetString(5);

                    result.Add(new Traveller()
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Jmb = reader.GetString(3),
                        IdCardNumber = _idCardNumber,
                        PassportNumber = _passportNumber
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTraveller", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void InsertTraveller(Traveller t)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@FirstName", t.FirstName);
                cmd.Parameters.AddWithValue("@LastName", t.LastName);
                cmd.Parameters.AddWithValue("@Jmb", t.Jmb);
                cmd.Parameters.AddWithValue("@IdCardNumber", t.IdCardNumber);
                cmd.Parameters.AddWithValue("@PassportNumber", t.PassportNumber);
                cmd.ExecuteNonQuery();
                t.Id = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTraveller", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }

        public void UpdateTraveller(Traveller t)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@FirstName", t.FirstName);
                cmd.Parameters.AddWithValue("@LastName", t.LastName);
                cmd.Parameters.AddWithValue("@Jmb", t.Jmb);
                cmd.Parameters.AddWithValue("@IdCardNumber", t.IdCardNumber);
                cmd.Parameters.AddWithValue("@PassportNumber", t.PassportNumber);
                cmd.Parameters.AddWithValue("@Id", t.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTraveller", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }

        public void DeleteTravellerById(int id)
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
                throw new DataAccessException("Exception in MySqlTraveller", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }
    }
}

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
    public class MySqlAccount : IAccount
    {
        private static readonly string SELECT = @"SELECT nalog.Id, KorisnickoIme, Lozinka, 
                                                  zaposleni.Id, Ime, Prezime, JMB, Zvanje, Plata 
                                                  FROM nalog inner join zaposleni on nalog.Zaposleni=zaposleni.Id;";

        public List<Account> GetAccounts()
        {
            List<Account> result = new List<Account>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    result.Add(new Account()
                    {
                        Id = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Password = reader.GetString(2),
                        Employee = new Employee()
                        {
                            Id = reader.GetInt32(3),
                            FirstName = reader.GetString(4),
                            LastName = reader.GetString(5),
                            Jmb = reader.GetString(6),
                            Education = reader.GetString(7),
                            Salary = reader.GetDecimal(8)
                        }
                    }) ;
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAccount", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public string CheckAccount(string username, string password)
        {
            int id = GetUserId(username, password);
            string result = "";

            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "vrsta_naloga";
                cmd.Parameters.AddWithValue("@pId", id);
                cmd.Parameters["@pId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pVrsta", MySqlDbType.Int32);
                cmd.Parameters["@pVrsta"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                result = cmd.Parameters["@pVrsta"].Value.ToString();

                }
                catch (Exception ex)
                {
                    throw new DataAccessException("Exception in MySqlAccount", ex);
                }
                finally
                {
                    MySqlUtil.CloseQuietly(conn);
                }
            return result;
            
        }

        private int GetUserId(string username, string password)
        {
            List<Account> accounts = GetAccounts();
            foreach(var a in accounts)
            {
                if (a.Username.Equals(username) && a.Password.Equals(password))
                    return a.Employee.Id;
            }
            return -1;
        }

        public Account GetAccountByUsername(string username)
        {
            List<Account> accounts = GetAccounts();
            foreach (var a in accounts)
            {
                if (a.Username.Equals(username))
                    return a;
            }
            return null;
        }
    }
}

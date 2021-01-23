using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.DataAccess
{
    public abstract class DataFactory
    {
        public abstract IAccount Accounts { get; }
        public abstract IAddress Addresses { get; }
        public abstract ICity Cities { get; }
        public abstract IEmployee Employees { get; }
        public abstract IOffice Offices { get; }
        public abstract ITraveller Travellers { get; }

        public static DataFactory GetMySqlDataFactory()
        {
            return new MySql.MySqlDataFactory();
        }
    }
}

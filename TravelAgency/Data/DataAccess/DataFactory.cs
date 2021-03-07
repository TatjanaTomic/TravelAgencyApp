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
        public abstract ITraveller Travellers { get; }
        public abstract IOffer Offers { get; }
        public abstract ITrip Trips { get; }
        public abstract ITravel Travels { get; }
        public abstract IReservation Reservations { get; }
        public abstract IBus Buses { get; }
        public abstract IReceipt Receipts { get; }

        public static DataFactory GetMySqlDataFactory()
        {
            return new MySql.MySqlDataFactory();
        }
    }
}

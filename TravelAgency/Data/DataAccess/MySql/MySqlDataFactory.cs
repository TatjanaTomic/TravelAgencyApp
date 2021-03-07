using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.DataAccess.MySql
{
    public class MySqlDataFactory : DataFactory
    {
        private MySqlAccount mySqlAccount;
        private MySqlOffer mySqlOffer;
        private MySqlTrip mySqlTrip;
        private MySqlTravel mySqlTravel;
        private MySqlTraveller mySqlTraveller;
        private MySqlReservation mySqlReservation;
        private MySqlBus mySqlBus;
        private MySqlReceipt mySqlReceipt;

        public override IAccount Accounts
        {
            get
            {
                if(mySqlAccount == null)
                {
                    mySqlAccount = new MySqlAccount();
                }
                return mySqlAccount;
            }
        }
        public override IReceipt Receipts
        {
            get
            {
                if(mySqlReceipt == null)
                {
                    mySqlReceipt = new MySqlReceipt();
                }
                return mySqlReceipt;
            }
        }

        public override ITraveller Travellers
        {
            get
            {
                if (mySqlTraveller == null)
                {
                    mySqlTraveller = new MySqlTraveller();
                }
                return mySqlTraveller;
            }
        }

        public override IOffer Offers
        {
            get
            {
                if(mySqlOffer == null)
                {
                    mySqlOffer = new MySqlOffer();
                }
                return mySqlOffer;
            }
        }

        public override ITrip Trips
        {
            get
            {
                if (mySqlTrip == null)
                {
                    mySqlTrip = new MySqlTrip();
                }
                return mySqlTrip;
            }
        }

        public override ITravel Travels
        {
            get
            {
                if (mySqlTravel == null)
                {
                    mySqlTravel = new MySqlTravel();
                }
                return mySqlTravel;
            }
        }

        public override IReservation Reservations
        {
            get
            {
                if (mySqlReservation == null)
                {
                    mySqlReservation = new MySqlReservation();
                }
                return mySqlReservation;
            }
        }

        public override IBus Buses
        {
            get
            {
                if (mySqlBus == null)
                {
                    mySqlBus = new MySqlBus();
                }
                return mySqlBus;
            }
        }
    }
}

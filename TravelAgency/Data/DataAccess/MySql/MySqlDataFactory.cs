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

        public override IAddress Addresses => throw new NotImplementedException();

        public override ICity Cities => throw new NotImplementedException();

        public override IEmployee Employees => throw new NotImplementedException();

        public override IOffice Offices => throw new NotImplementedException();

        public override ITraveller Travellers => throw new NotImplementedException();
    }
}

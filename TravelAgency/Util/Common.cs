using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data.DataAccess;

namespace TravelAgency.Util
{
    public static class Common
    {
        private static DataFactory dataFactory;
        public static DataFactory DataFactory
        {
            get
            {
                if (dataFactory == null)
                {
                    string travelAgencyFactory = ConfigurationManager.AppSettings["TravelAgencyFactory"];
                    if ("MySql".Equals(travelAgencyFactory))
                    {
                        dataFactory = DataFactory.GetMySqlDataFactory();
                    }
                }
                return dataFactory;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data.Model;

namespace TravelAgency.Data.DataAccess
{
    public interface ITraveller
    {
        List<Traveller> GetTravellers(string filter);
        void InsertTraveller(Traveller t);
        void UpdateTraveller(Traveller t);
        void DeleteTravellerById(int id);
    }
}

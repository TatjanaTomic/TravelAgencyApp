using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data.Model;

namespace TravelAgency.Data.DataAccess
{
    public interface ITrip
    {
        List<Trip> GetTrips(string filter);
        void DeleteTripById(int id, int priceId);
        void InsertTrip(Trip t);
        void UpdateTrip(Trip t);
    }
}

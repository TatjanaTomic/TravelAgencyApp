using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data.Model;

namespace TravelAgency.Data.DataAccess
{
    public interface ITravel
    {
        List<Travel> GetTravels(string filter);
        void DeleteTravelById(int id, int priceId);
        void InsertTravel(Travel t);
        void UpdateTravel(Travel t);
    }
}

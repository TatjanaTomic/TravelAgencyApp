using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data.Model;

namespace TravelAgency.Data.DataAccess
{
    public interface IReservation
    {
        List<Reservation> GetReservations(string filter);
        void InsertReservation(int managerID, int travellerID, int offerID);
        void DeleteReservation(int travellerID, int offerID);
    }
}

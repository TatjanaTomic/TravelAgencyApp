using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data.Model;

namespace TravelAgency.Data.DataAccess
{
    public interface IOffer
    {
        List<(Offer,int,int)> GetOffers(string filter);
        int CountReservations(int id);
        List<Offer> GetActiveOffers(string filter);

    }
}

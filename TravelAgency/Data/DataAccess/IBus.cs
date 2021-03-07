using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data.Model;

namespace TravelAgency.Data.DataAccess
{
    public interface IBus
    {
        List<Bus> GetBuses(string filter);
        void InsertBus(Bus b);
        void UpdateBus(Bus b);
        void DeleteBusByLicensePlate(string lp);
    }
}

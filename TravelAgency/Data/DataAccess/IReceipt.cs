using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data.Model;

namespace TravelAgency.Data.DataAccess
{
    public interface IReceipt
    {
        List<Receipt> GetReceipts(string filter);
        void UpdateReceipt(Receipt r);
        void DeleteReceipt(int id);
        void InsertReceipt(Receipt r);
        int CheckIfExists(int offer, int traveller);
        int CheckSeat(Receipt r);
    }
}

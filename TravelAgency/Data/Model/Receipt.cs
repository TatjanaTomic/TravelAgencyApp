using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Model
{
    public class Receipt
    {
        public int Id { get; set; }
        public DateTime DateOfCreation { get; set; }
        public Offer Offer { get; set; }
        public Traveller Traveller { get; set; }
        public int NumberOfBus { get; set; }
        public int NumberOfSeat { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Receipt receipt &&
                   Id == receipt.Id &&
                   EqualityComparer<Offer>.Default.Equals(Offer, receipt.Offer) &&
                   EqualityComparer<Traveller>.Default.Equals(Traveller, receipt.Traveller);
        }

        public override int GetHashCode()
        {
            int hashCode = 1565431273;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Offer>.Default.GetHashCode(Offer);
            hashCode = hashCode * -1521134295 + EqualityComparer<Traveller>.Default.GetHashCode(Traveller);
            return hashCode;
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}

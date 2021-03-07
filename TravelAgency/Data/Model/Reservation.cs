using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Model
{
    public class Reservation
    {
        public DateTime DateOfReservation { get; set; }
        public Employee Manager { get; set; }
        public Traveller Traveller { get; set; }
        public Offer Offer { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Reservation reservation &&
                   EqualityComparer<Traveller>.Default.Equals(Traveller, reservation.Traveller) &&
                   EqualityComparer<Offer>.Default.Equals(Offer, reservation.Offer);
        }

        public override int GetHashCode()
        {
            int hashCode = 428558337;
            hashCode = hashCode * -1521134295 + EqualityComparer<Traveller>.Default.GetHashCode(Traveller);
            hashCode = hashCode * -1521134295 + EqualityComparer<Offer>.Default.GetHashCode(Offer);
            return hashCode;
        }

        public override string ToString()
        {
            return "Datum kreiranja " + DateOfReservation;
        }
    }
}

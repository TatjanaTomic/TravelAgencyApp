using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Model
{
    public class Trip
    {
        public Offer Offer { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeDeparture { get; set; }
        public TimeSpan TimeReturn { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Trip trip &&
                   EqualityComparer<Offer>.Default.Equals(Offer, trip.Offer);
        }

        public override int GetHashCode()
        {
            return -691664123 + EqualityComparer<Offer>.Default.GetHashCode(Offer);
        }

        public override string ToString()
        {
            return Offer.ToString() + " Datum: " + Date.ToString() + " Polazak: " + TimeDeparture.ToString() + " Povratak: " + TimeReturn.ToString();
        }
    }
}
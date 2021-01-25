using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Model
{
    public class Travel
    {
        public Offer Offer { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Return { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Travel travel &&
                   EqualityComparer<Offer>.Default.Equals(Offer, travel.Offer);
        }

        public override int GetHashCode()
        {
            return -691664123 + EqualityComparer<Offer>.Default.GetHashCode(Offer);
        }

        public override string ToString()
        {
            return Offer.ToString() + " Polazak: " + Departure.ToString() + " Povratak: " + Return.ToString();
        }
    }

}

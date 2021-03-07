using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Model
{
    public class Bus
    {
        public string LicensePlate { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int NumberOfSeats { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Bus bus &&
                   LicensePlate == bus.LicensePlate;
        }

        public override int GetHashCode()
        {
            return -1210158992 + EqualityComparer<string>.Default.GetHashCode(LicensePlate);
        }

        public override string ToString()
        {
            return LicensePlate;
        }

    }
}

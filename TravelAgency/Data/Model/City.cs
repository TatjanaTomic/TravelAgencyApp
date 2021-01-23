using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PostalCode { get; set; }
        public string State { get; set; }

        public override bool Equals(object obj)
        {
            return obj is City city &&
                   Id == city.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return Name + " " + PostalCode + " " + State;
        }
    }
}

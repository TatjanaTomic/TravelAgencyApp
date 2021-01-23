using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Model
{
    public class Address
    {
        public int Id { get; set; } 
        public string Street { get; set; }
        public int Number { get; set; }
        public City City { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Address address &&
                   Id == address.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return Street + " " + Number + " " + City.ToString();
        }
    }
}

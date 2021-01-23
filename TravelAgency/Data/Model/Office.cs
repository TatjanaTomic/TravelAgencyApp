using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Model
{
    public class Office
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Jib { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public Office MainOffice { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Office office &&
                   Id == office.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return Name + " " + Email + " " + Jib;
        }
    }
}

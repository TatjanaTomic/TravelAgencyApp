using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Model
{
    public class Traveller
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Jmb { get; set; }
        public string IdCardNumber { get; set; }
        public string PassportNumber { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Traveller traveller &&
                   Id == traveller.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Jmb; 
        }
    }
}

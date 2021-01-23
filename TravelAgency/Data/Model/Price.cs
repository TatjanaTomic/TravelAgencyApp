using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Model
{
    public class Price
    {
        public int Id { get; set; }
        public decimal TransportCost { get; set; }
        public decimal Accommodation { get; set; }
        public decimal TravelInsurance { get; set; }
        public decimal TouristTax { get; set; }
        public decimal TotalPrice { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Price price &&
                   Id == price.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return "Troskovi prevoza " + TransportCost + "; " + "troskovi smjestaja " + Accommodation + "; " + "cijena osiguranja " + TravelInsurance + "; " + "boravisna taksa " + TouristTax + "; " + "ukupna cijena " + TotalPrice + "; ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdministrator { get; set; }
        public Employee Employee { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Account account &&
                   Id == account.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return Id + " " + Username;
        }
    }
}

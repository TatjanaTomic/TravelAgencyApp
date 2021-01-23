using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Jmb { get; set; }
        public string Education { get; set; }
        public decimal Salary { get; set; }
        public Office Office { get; set; }
        public Address Address { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   Id == employee.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return Id + " " + FirstName + " " + LastName + " " + Jmb + " " + Education + " " + Salary;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data.Model;

namespace TravelAgency.Data.DataAccess
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
    }
}

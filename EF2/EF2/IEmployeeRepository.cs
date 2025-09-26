using EF2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2
{
    internal interface IEmployeeRepository : IDisposable
    {
        IEnumerable<Employee> SearchByName(string name);
        void AddEmployee(Employee employee);
    }
}

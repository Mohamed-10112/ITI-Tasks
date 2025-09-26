using EF1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1
{
    internal interface IEmployeeRepository : IDisposable
    {
        IEnumerable<EmployeeView> SearchByName(string name);
        void AddEmployee(Employee employee);
    }
}

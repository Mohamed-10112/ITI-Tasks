using EF2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private readonly CompanySdContext context;
        private bool disposed = false;

        public EmployeeRepository(CompanySdContext context)
        {
            this.context = context;
        }

        public IEnumerable<Employee> SearchByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return new List<Employee>();

            name = name.Trim();

            return context.Employees
                          .Include(e => e.Department)
                          .Where(e => e.Fname != null && e.Fname.Contains(name))
                          .ToList();
        }

        public void AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            context.Employees.Update(employee);
            context.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            context.Employees.Remove(employee);
            context.SaveChanges();
        }

        public IQueryable<Employee> GetAllEmployees()
        {
            return context.Employees.AsQueryable();
        }

        public void Dispose()
        {
            if (!disposed)
            {
                context.Dispose();
                disposed = true;
            }
        }
    }
}

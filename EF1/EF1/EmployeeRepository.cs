using EF1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private readonly CompanySdContext context;
        private bool disposed = false;
        public EmployeeRepository(CompanySdContext context)
        {
            this.context = context;
        }
        public IEnumerable<EmployeeView> SearchByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return new List<EmployeeView>();

            name = name.Trim();
            return context.Employees
                           .Where(e => e.Fname != null && e.Fname.Contains(name))
                           .Select(e => new EmployeeView
                           {
                               Fname = e.Fname,
                               Lname = e.Lname,
                               Address = e.Address,
                               Salary = e.Salary ?? 0
                           })
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
        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employees.ToList();
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

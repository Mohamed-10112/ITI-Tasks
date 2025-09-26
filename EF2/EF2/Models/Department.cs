using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}

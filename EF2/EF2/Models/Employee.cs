using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Models
{
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ssn { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Address { get; set; }
        public int? Salary { get; set; }

        public int? DepartmentId { get; set; } 
        public Department? Department { get; set; }

        [NotMapped]
        public string? DepartmentName => Department != null ? Department.Name : "";
    }
}

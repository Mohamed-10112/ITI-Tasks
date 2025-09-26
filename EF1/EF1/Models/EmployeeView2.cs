using System;
using System.Collections.Generic;

namespace EF1.Models;

public partial class EmployeeView2
{
    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public int Ssn { get; set; }

    public DateTime? Bdate { get; set; }

    public string? Address { get; set; }

    public string? Sex { get; set; }

    public int? Salary { get; set; }

    public int? Superssn { get; set; }

    public int? Dno { get; set; }
}

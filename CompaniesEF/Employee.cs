using System;
using System.Collections.Generic;

namespace CompaniesEF
{
    public class Employee
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public DateTime Birthate { get; set; }
        public double Salary { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
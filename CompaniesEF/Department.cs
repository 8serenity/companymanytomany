using System.Collections;
using System.Collections.Generic;

namespace CompaniesEF
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Moto { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompaniesEF
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Income { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
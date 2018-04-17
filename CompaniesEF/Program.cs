using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Написать приложение, в котором есть следующие условия:

//1. В компаниях есть отделы
//2. В отделах есть сотрудники
//3. Каждый сотрудник может числиться в нескольких отделах

//Описать всё с помощью EF.

namespace CompaniesEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CompanyContext())
            {
                var result = context.Companies.ToList();
            }
        }
    }
}

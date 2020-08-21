using Exercices.EX2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalEmployee _localEmployee1 = new LocalEmployee();
            _localEmployee1.FirstName = "Employee1";
            _localEmployee1.LastName = "lanme2";
            _localEmployee1.SalaryPerHour = 100;
            _localEmployee1.BaseSalary = 8000;

            LocalEmployee _localEmployee2 = new LocalEmployee();
            _localEmployee2.FirstName = "Employee2";
            _localEmployee2.LastName = "lanme2";
            _localEmployee2.SalaryPerHour = 100;
            _localEmployee1.BaseSalary = 8000;


            List<LocalEmployee> LocalEmployees = new List<LocalEmployee>();
            LocalEmployees.Add(_localEmployee1);
            LocalEmployees.Add(_localEmployee2);                   
            
            var employee = _localEmployee1.GetAverageSalaryPerHour(LocalEmployees).Select(x => x.employee.FirstName == "Employee1").FirstOrDefault();

            Console.WriteLine("Hello World!");
            Console.ReadKey();

        }

    }
}


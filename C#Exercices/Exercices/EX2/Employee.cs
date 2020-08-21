using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.EX2
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SalaryPerHour { get; set; }
        public int BaseSalary { get; set; }

        public int Salary(int hoursWorked) {

            int TotalSalry = hoursWorked * BaseSalary;

            int ExtarHour = 0;

            if (hoursWorked > 48)
            {

                ExtarHour = (BaseSalary * 30) / 100;
            }

            return TotalSalry + ExtarHour;
        }

        public int ExtraSalary(int hoursWorked) {
            return 0;
        }

    }
}

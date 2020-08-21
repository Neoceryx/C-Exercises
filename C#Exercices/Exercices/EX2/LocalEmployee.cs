using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.EX2
{
    public class LocalEmployee: Employee
    {

        public List<Result> GetAverageSalaryPerHour(List<LocalEmployee> Employees) {

            LocalEmployee _lEmployee = new LocalEmployee();

            List<Result> results = new List<Result>();

            foreach (var _employee in Employees)
            {
                _lEmployee.BaseSalary = _employee.BaseSalary;

                int salary = _lEmployee.Salary(49);

                Result _r = new Result();
                _r.employee = _employee;

                results.Add(_r);
                
            }
            
            return results;

        }

    }
}

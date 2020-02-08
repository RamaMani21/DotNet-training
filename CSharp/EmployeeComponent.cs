using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employeecomponent;


namespace emp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 emp = new Class1() { EmployeeID = 1, EmpName = "rama", Department = "technical" };

            var empdata =emp.showData();
            Console.WriteLine(empdata);
            var salary = emp.GetSalary(30, 800.00);
            var incent = emp.GetIncentives(salary);

            var tSalary = salary + incent;
            Console.WriteLine("Salary:{0}, Incentives:{1},Total Salary:{2}", salary, incent, tSalary);

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqpro
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        List<Employee> Employees = new List<Employee>();

            Employees.Add(new Employee() { EmpID = 1, EmpName = "rama" });
            Employees.Add(new Employee() { EmpID = 2, EmpName = "dhoni" });
            Employees.Add(new Employee() { EmpID = 3, EmpName = "anju" });


            var proEmpls = from emp in Employees
                           where emp.EmpName.Contains("a")
                           select new { ename = emp.EmpName };

            foreach (var emp in proEmpls)
            {
                Console.WriteLine("Employee with a: {0}", emp.ename);
            }
             Console.WriteLine("*******************************************");}



           public class Employee
           {
                public int EmpID { get; set; }
                public string EmpName { get; set; }
           }

    }
}

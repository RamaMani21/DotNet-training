using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEFDBFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesDBEntities context = new EmployeesDBEntities();


            //var employee = new Employee()
            //{
            //    EmpID = 1,
            //    Name = "Andrew",
            //    Salary = 35000,
            //    SSN = 234567,
            //    DeptID = 3
            //};

            //context.Employees.Add(employee);
            //context.SaveChanges();

            //LinqToEntity();
            //ModifyEmployee();
            DeleteEmployee();

        //    var employee2 = new Employee()
        //    {
        //        EmpID = 2,
        //        Name = "Jaffrey",
        //        Salary = 35000,
        //        SSN = 785877,
        //        DeptID = 3
        //    };


            //    context.Employees.Add(employee2);

            //    var employee3 = new Employee()
            //    {
            //        EmpID = 3,
            //        Name = "Ritchie",
            //        Salary = 35000,
            //        SSN = 684907,
            //        DeptID = 3
            //    };


            //    context.Employees.Add(employee3);
            //    context.SaveChanges();
        }

        public static void LinqToEntity()
        {
            EmployeesDBEntities context = new EmployeesDBEntities();
            var employee = context.Employees;
            var empList = from emp in employee
                          orderby emp.Salary
                          select emp;

            foreach (var emp in empList)
            {
                Console.WriteLine("EmpID: {0}, Name: {1}, Salary: {2}, SSN: {3}", emp.EmpID, emp.Name, emp.Salary, emp.SSN);
            }

        }

        public static void ModifyEmployee()
        {
            EmployeesDBEntities context = new EmployeesDBEntities();
            var employee = context.Employees;
            var empList = from emp in employee
                          orderby emp.Salary
                          select emp;

            foreach (var emp in empList)
            {
                if (emp.EmpID == 1)
                    emp.Name = "mathew mcdonald";
            }
            context.SaveChanges();
        }

        public static void DeleteEmployee()
        {
            EmployeesDBEntities context = new EmployeesDBEntities();
            var employees = context.Employees;

            var employee = new Employee { EmpID = 4 };
            employees.Attach(employee);
            employees.Remove(employee);
            context.SaveChanges();
              
        }
    }
}



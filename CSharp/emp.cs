using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeecomponent
{
    public class Class1
    {
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }


        public double GetSalary(int nds,double spd)
        {
            var salary = nds * spd;
            return salary;

        }

        public double GetIncentives(double Salary)
        {
            var incent = 0.05 * Salary;
            return incent;

        }
        public string showData()
        {
            return string.Format("EmployeeID: {0}, EmpName = {1}, Department = {2}", EmpName, EmployeeID, Department);

        }
    }
}

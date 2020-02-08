using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)                //entry point of csharp console application
        {
            Employee emp = new Employee();
            var salary = emp.GetSalary(30, 800);
            Console.WriteLine("salary without incentives: Rs{0}", salary);


            salary = emp.GetSalary(30, 800, 5000);
            Console.WriteLine("salary with incentives: Rs{0}", salary);

            Manager objM = new Manager();
            var ts=objM.GetPerks(30000, 5000);
            Console.WriteLine("salary of manager: Rs{0}", ts);



            Console.ReadKey();
        }
    }

    public class Employee
    {
        public double GetSalary(int nds, float spd)                 //this method can be overloaded with different signatures
        {
            double salary = nds * spd;
            return salary;

        }

        public double GetSalary(int nds ,float spd, float incent)  //GetSalary method is overloaded
        {
            double salary = (nds * spd)+incent;

            return salary;
        }

        //this method will be overridden in some other derived class
        public virtual double GetPerks(float salary, float perks)
        {
            double ts = salary + perks;
            return ts;
        }

    }

    public class Manager:Employee
    {
        public override double GetPerks(float salary,float perks)        //signature remains same while overriding
        {
            //return base GetPerks(salary,perks)*1.10;                     // 'base' keyword refers to the base class

            double ts = 1.10 * (salary + perks);
            return ts;
            
        }
    }




}

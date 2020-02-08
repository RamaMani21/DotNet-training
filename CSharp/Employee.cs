using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int empAge;
            string empName;

            Console.WriteLine("Enter employee name\n");
            empName = Console.ReadLine();
            Console.WriteLine("Enter employee age\n");
            empAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Congratulations Mr/Miss {0} on your {1} Birthday", empName, empAge);
            Console.ReadKey();
        }
    }
}

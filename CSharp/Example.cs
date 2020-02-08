using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            int empAge;
            string empName;
            Console.WriteLine("enter employee age\n");
            empAge = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee name\n");
            empName =Console.ReadLine();
            Console.WriteLine("congratulations");
            Console.ReadKey();
        }
    }
}

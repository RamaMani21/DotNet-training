using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            
            Console.WriteLine("Enter num1 value");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2 value");
            num2 = int.Parse(Console.ReadLine());
            int result = num1 * num2;
            Console.WriteLine("result : {0} * {1} = {2}",num1, num2, result);
           



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] marks = new int[] { 89, 90, 93, 94, 95, 98 };
            for (int i = 0; i < marks.Length; i++)
                Console.WriteLine("marks ={0}", marks[i]);



            string[] employee = new string[] { "rama", "anju", "vineetha", "rithika" };
            for (int i = 0; i < employee.Length; i++)
                Console.WriteLine("employee ={0}", employee[i]);

            Console.ReadKey();
        }
    }
}

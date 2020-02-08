using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTION
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] marks = new int[] { 85, 98, 78, 67, 63, 25 };


                for (int i = 0; i <= 6; i++)
                {
                    Console.WriteLine("Subject Marks {0}= {1}", i + 1, marks[i]);
                }

                Console.WriteLine("rest of the code gets executed here");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            try
            {
                int a, b, c;

                Console.WriteLine("enter numerator");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("enter denominator");
                b = int.Parse(Console.ReadLine());

                if (b == 0)
                    throw new DivideByZeroException("Denominator cannot be zero");
                else
                {
                    c = a / b;
                    Console.WriteLine("c={0}", c);
                }
            }

             catch (DivideByZeroException e)
             {
                Console.WriteLine(e.Message);
             }
             Console.ReadKey();

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_type_program_demo
{
    class Program
    {
        static void Main(string[] args)
        {

            byte b = 255;

            short s = 99;

            int n = 98;

            long l = 565787878;

            float f = 10.99f;

            double d = 30.99;

            decimal m = 999.9m;

            Console.WriteLine("values of b={0}, s={1}, n={2}, l={3}, f={4}, d={5}, m={6}", b, s, n, l, f, d, m);
          
            DateTime dd = DateTime.Now;
            Console.WriteLine("The current date is: {0}", dd); 
            Console.WriteLine("The current date is: {0}", dd.ToShortDateString());
            Console.WriteLine("The current date is: {0}", dd.ToLongDateString());
            Console.WriteLine("the current time is: {0}", dd.ToShortTimeString());
            Console.WriteLine("the current time is: {0}", dd.ToLongTimeString());
            Console.ReadKey();


            int q, r;
            q = 20; r = 10;   


            Add(q, r);
            double ss = Multiply(q, r);
            Console.WriteLine("the product of {0} and {1}={2}", q, r, ss);
            Console.ReadKey();
        }

        public static void Add(int q, int r)
        {
            double ss = q + r;
            Console.WriteLine("the sum of {0} and {1}={2}", q, r, ss);
        }

        public static double Multiply(int q, int r)
        {
            double ss = q * r;
            return ss;
        }
    }
}

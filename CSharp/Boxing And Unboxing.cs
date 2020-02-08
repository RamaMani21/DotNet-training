using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxing_and_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            object obj = 100;          //object is the reference type

            int a = 100;

            obj = a;                 //converting a value type to a reference type is called boxing

            int b = (int)a;         //converting a boxed type into value type by explicitly casting it is called unboxing

            Console.WriteLine("values of a and b={0} and {1} ", a, b);



            //passing arguments by value type


            int i, j;
            i = 10; j = 20;

            Console.WriteLine("values of i and j before function call = {0}, {1}", i, j);
            ShowData1(i, j);

            Console.WriteLine("values of i and j after function call = {0}, {1}", i, j);

            int k, l;
            k = 10; l = 20;
            //passing arguments by reference
            Console.WriteLine("values of k and l before function call = {0}, {1}", k, l);
            ShowData2(ref k, ref l);
            Console.WriteLine("values of k and l after function call = {0}, {1}", k, l);



            Console.ReadLine();
        }



        public static void ShowData1(int a, int b)
        {
            double sum = a + b;
            Console.WriteLine("sum={0}", sum);
            a += 5;
            b += 5;

        }
        public static void ShowData2(ref int a, ref int b)
        {
            double sum = a + b;
            Console.WriteLine("sum={0}", sum);
            a += 5;
            b += 5;


        }
    }
}

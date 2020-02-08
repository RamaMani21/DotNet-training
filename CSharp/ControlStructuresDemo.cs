using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_structures_demo
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 50;
            if (a >= 10)
            {
                Console.WriteLine("good morning");
            }
            else if (a < 10)
            {
                Console.WriteLine("good evening");
            }
            else
                Console.WriteLine("good night");

            int b = 1;
            switch(b)
            {
                case 1:Console.WriteLine("hello, how are you?");
                    break;
                case 2:
                    Console.WriteLine("hi, how do you do?");
                    break;
                case 3:
                    Console.WriteLine("hello");
                    break;
                default:
                    Console.WriteLine("hope, you are doing well");
                    break;

            }


            //loop structure
            Console.WriteLine("write a number to display its tables");

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0}*{1} = {2}", number, i, number * i);

            int m = 10;

            do
            {
                Console.WriteLine("{0}is less than 100", m);
                m = m + 10;
            } while (m < 100);



            int n = 10;

            while (n < 100) 

            {
                Console.WriteLine("{0}is less than 100", n);
                n = n + 10;
            }



            int fact, fn;
            fact = 1;

            Console.WriteLine("enter a number");
            fn = int.Parse(Console.ReadLine());

            for (int j = 1; j <= fn; j++)
                fact = fact * j; ;
            Console.WriteLine("the factoria; of {0} = {1}", fn, fact);


            Console.ReadKey();


        }
    }
}

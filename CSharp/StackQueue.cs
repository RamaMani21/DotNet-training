using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue
{
    class Program
    {
        static void Main(string[] args)
        {



            int a, b;
            a = 30; b = 50;
            Console.WriteLine("before swap: a={0},b={1}",a,b);
            swap<int>(ref a, ref b);
            Console.WriteLine("after swap: a={0},b={1}", a, b);


            //stack and queue data structures
            //stack is LIFO and queue is FIFO

            Stack<float> fnumbers = new Stack<float>();
            fnumbers.Push(20.12f);
            fnumbers.Push(10.12f);
            fnumbers.Push(30.12f);
            fnumbers.Push(40.12f);

            foreach (var fn in fnumbers)
            Console.WriteLine(fn);

            fnumbers.Pop();
                Console.WriteLine("\nAfter calling the pop method");
            foreach (var fn in fnumbers)
                Console.WriteLine(fn);




            Queue<double> qnumbers = new Queue<double>();
            qnumbers.Enqueue(20.12);
            qnumbers.Enqueue(10.12);
            qnumbers.Enqueue(14.12);
            qnumbers.Enqueue(13.12);

            Console.WriteLine("\nBefore calling the dequeue method");

            foreach (var qn in qnumbers)
                Console.WriteLine(qn);

            qnumbers.Dequeue();

            Console.WriteLine("\nAfter calling the dequeue method");
            foreach (var qn in qnumbers)
                Console.WriteLine(qn);



            
            Console.ReadKey();



        }
        public static void swap<T>(ref T a, ref T b)
        {
            T c;
            c = a;
            a = b;
            b = c;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threading
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("main thread is started");
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("{0} is running now with ID:{1}", t.Name, t.ManagedThreadId);
            //Method();
            //Method1();                   //method1 is implicitly handled by the ThreadStart delegate
            //Method2();

            Thread T1 = new Thread(new ThreadStart(Method));
            Thread T2 = new Thread(Method1);
            Thread T3 = new Thread(Method2);

            T1.Start();
            T2.Start();
            T3.Start();


            
            Thread Tp = new Thread(new ParameterizedThreadStart(Test));
            Tp.Start(100);

            T1.Join(); T2.Join(); T3.Join(); Tp.Join();       //Join() method is responsible for preventing the main thread to exit from the fray unless all the child 
                                                                //threads have completed with  their tasks.






            Thread Tarea = new Thread(new ThreadStart(FindArea));
            //Tarea.Start(100);
            
            Console.WriteLine("the thread is exited");
            Console.ReadKey();


           
        }

        
        public static void Method()
        {
            
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Method:{0}", i);

        }

        public static void Method1()
        {
            Console.WriteLine("thread2 is started");

            for (int i = 1; i <= 50; i++)
            {
                if (i == 25)
                {
                    Thread.Sleep(5000);
                }
                Console.WriteLine("Method1:{0}", i);
            }
        }

        public static void Method2()
        {
            Console.WriteLine("thread3 is started");
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Method2:{0}", i);
                
            }
        }

        public static void Test(object max)
        {
            int j = Convert.ToInt32(max);
            for (int i = 1; i <= j; i++)
                Console.WriteLine("Test:{0}", i);
        }

        public static void  FindArea()
        {
            double len, brd;
            Console.WriteLine("enter length");
            len = double.Parse(Console.ReadLine());

            Console.WriteLine("enter breadth");
            brd = double.Parse(Console.ReadLine());

            Console.WriteLine("area of rectangle:{0}", (len * brd).ToString());

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate1
{
    class Program
    {
        public delegate int MathDelegate(int n1,int n2);
        static void Main(string[] args)
        {
            MathDelegate deleg = new MathDelegate(Addnum);
            var num = deleg.Invoke(5, 10);
            Console.WriteLine("Addition={0}", num);

            deleg+= Mulnum;
            var num1 = deleg.Invoke(5, 10);
            Console.WriteLine("Multiplication={0}", num);

            deleg+= Subnum;
            var num2 = deleg.Invoke(5, 10);
            Console.WriteLine("Subtraction={0}", num);

            deleg+= Divnum;
            var num3= deleg.Invoke(5, 10);
            Console.WriteLine("Division={0}", num);
        }


        static int num = 5;
        public static int Addnum(int a)
        {
            num += a;
            return num;

        }

        public static int Mulnum(int b)
        {
            num *= b;
            return num;
        }

        public static int Subnum(int c)
        {
            num -= c;
            return num;
        }

        public static int Divnum(int d)
        {
            num /= d;
            return num;
        }

    }
}
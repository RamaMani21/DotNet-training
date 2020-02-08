using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string message=Greetings(21,"rama");
            var message = Greetings(21, "rama");   //var is used implicitly typed local variables
            Console.WriteLine(message);
            Console.ReadKey();

        }

        public static string Greetings(int age, string name)
        {
            return string.Format("Congratulations mr/mrs {0} on your {1}birthday", name, age);
        }

    }
}
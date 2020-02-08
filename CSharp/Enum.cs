using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
          //

            enum Department
        {
            Physics = 10,
            Chemistry = 12,
            Mathematics = 15,
            Biology = 19
        };

        enum color
        {
            Red = 1,
            Blue = 2,
            Black = 3
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Department ID of Physics: {0}", (int)Department.Physics);
            Console.WriteLine("Department ID of Physics: {0}", (int)Department.Chemistry);
            Console.WriteLine("Department ID of Physics: {0}", (int)Department.Mathematics);
            Console.WriteLine("Department ID of Physics: {0}", (int)Department.Biology);


            Console.WriteLine("color Red indicates: {0}", (int)color.Red);
            Console.WriteLine("color Blue indicates: {0}", (int)color.Blue);
            Console.WriteLine("color Black indicates: {0}", (int)color.Black);

        }
    }
}

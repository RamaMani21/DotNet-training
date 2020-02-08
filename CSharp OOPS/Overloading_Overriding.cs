using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading_overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            var Totalmarks = stu.GetTotal(90, 70);
            Console.WriteLine("Total marks:{0}", Totalmarks);

            Totalmarks = stu.GetTotal(90, 70, 50);

            Console.WriteLine("Grand Total marks:{0}", Totalmarks);


            Console.ReadKey();
        }
    }


    public class Student
    {
        public double GetTotal(float m1, float m2)                 //this method can be overloaded with different signatures
        {
            double Total = m1 + m2;
            return Total;

        }

        public double GetTotal(float m1, float m2, float m3)  //GetSalary method is overloaded
        {
            double Total = (m1 + m2 + m3); 

            return Total;
        }

        
    }
}




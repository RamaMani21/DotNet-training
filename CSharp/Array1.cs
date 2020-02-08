using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] marks = new int[] { 89, 90, 93, 94, 95, 98 };
            for(int i=0; i<marks.Length; i++)
            {
                Console.WriteLine("subject{0} marks={1}", i + 1, marks[i]);
            }
            foreach(var mrk in marks)
            {
                Console.WriteLine("subjec tMarks={0}",mrk);
            }
            string[] employee = new string[] { "rama", "anju", "vineetha", "rithika" };
            foreach(var emp in employee)
            {
                Console.WriteLine("employee->{0}", emp);
            }

            var avgMarks = GetAverageMarks(marks);
            Console.WriteLine("average of marks = {0}", avgMarks);
            Console.ReadKey();
        }

        public static double GetAverageMarks(int[] marks)
        {
            int total = 0;
            double avg;
            for(int i = 0; i < marks.Length; i++) 
               total = total + marks[i];  

            avg = total / marks.Length;
            return avg;
        }
    }
}

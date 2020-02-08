using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6] { 78, 88, 70, 50, 50, 87 };

            Result objR = new Result();                //result class is instantiated

            var avg = objR.GetAverageMarks(marks);     //accessing the result calss functionality
            objR.DisplayAverage(avg);
            objR.ShowGrade(avg);

        }
    }

    public interface IExam
    {
        double GetAverageMarks(int[] marks);
        void DisplayAverage(double avg);
    }


    public interface IStudent
    {
        void ShowGrade(double avg);
    }


    public class Result:IExam,IStudent
    {
        public void DisplayAverage(double avg)
        {
            Console.WriteLine("the average marks={0}", avg);

        }

        public double GetAverageMarks(int[] marks)
        {
            int total;
            double avg;
            total = 0;
            for (int i = 0; i < marks.Length; i++)
                total += marks[i];


            avg = total / marks.Length;
            return avg;


        }

        public void ShowGrade(double avg)
        {
            if (avg >= 70.0)
                Console.WriteLine("passed in distintion");
            else
                Console.WriteLine("not passed in distintion");
        }
       
           
    }
}

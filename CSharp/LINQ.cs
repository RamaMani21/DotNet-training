using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employees = new string[6] { "dhoni", "karthik", "rama", "anju", "rithika", "vineetha" };
            var knownEmpls = from emp in employees
                             where emp.StartsWith("r")
                             select emp;

            foreach (string emp in knownEmpls)
            {
                Console.WriteLine("empname starts with r: {0}", emp);
            }


            //using method syntax
            var someEmpls = employees.Where(s => s.Contains("d"));

            foreach (string emp in someEmpls)
            {
                Console.WriteLine("empname starts with d: {0}", emp);
            }

            Console.WriteLine("*******************************************");

            List<string> fruits = new List<string>() { "apple", "kiwi", "orange", "grapes", "banana", "watermelon" };
            var fruitswithp = from fruit in fruits
                              where fruit.Contains("r")
                              select fruit;

            foreach (string fruit in fruitswithp)
            {
                Console.WriteLine("fruit with letter r: {0}", fruit);
            }
            Console.WriteLine("*******************************************");

            var TargetNameFruits = from fruit in fruits
                                   where fruit.Length > 6
                                   select fruit;



            foreach (string fruit in TargetNameFruits)
            {
                Console.WriteLine("fruit with length greater than 6: {0}", fruit);
            }

            Console.WriteLine("*******************************************");


            //using method syntax
            var smallernamefruits = fruits.Where(fruit => fruit.Length < 6);

            foreach (string fruit in smallernamefruits)
            {
                Console.WriteLine("fruit with length lessthan than 6: {0}", fruit);
            }

            Console.WriteLine("*******************************************");

            int[] marks = new int[6] { 78, 89, 90, 56, 78, 65 };

            var highestmarks = from m in marks
                               where m > 80
                               select m;


            foreach (var m in highestmarks)
            {
                Console.WriteLine("marks greaterthan than 80: {0}", m);
            }



            Console.WriteLine("*******************************************");

            int[] totalmarks = new int[6] { 78, 89, 90, 56, 78, 65 };

            var orderbymarks = from m in marks
                               orderby m
                               select m;


            foreach (var m in orderbymarks)
            {
                Console.WriteLine("marks: {0}", m);
            }

            Console.WriteLine("*******************************************");

            //using method syntax
            var marksinorder = marks.OrderByDescending(m => m);
            foreach (var m in marksinorder)
            {
                Console.WriteLine("descending order of marks: {0}", m);
            }

            Console.WriteLine("*******************************************");


            List<Product> Products = new List<Product>();

            Products.Add(new Product() { ProID = 1, ProName = "snickers" });
            Products.Add(new Product() { ProID = 2, ProName = "kitkat" });
            Products.Add(new Product() { ProID = 3, ProName = "mars" });



            var proProd = from pro in Products
                          where pro.ProName.Contains("a")
                          select pro;

            foreach (var pro in proProd)
            {
                Console.WriteLine("ProductID:{0},ProductName:{1}", pro.ProID, pro.ProName);
            }
            Console.WriteLine("*******************************************");



            List<Teacher> Teachers = new List<Teacher>() {new Teacher {ID = 1, FirstName = "anders", LastName = "helsberg", city = "zurich"} ,

                                                      new Teacher {ID = 2, FirstName = "andrew", LastName = "tie", city = "san fransico"} ,

                                                      new Teacher {ID = 3, FirstName = "jeffery", LastName = "ritcher", city = "seattle"} };


            List<Student> Students = new List<Student>() {new Student {ID = 1, FirstName = "jason", LastName = "roy", city = "zurich"} ,

                                                      new  Student {ID = 2, FirstName = "jhonny", LastName = "bairstow", city = "san fransico"} ,

                                                      new  Student {ID = 3, FirstName = "david", LastName = "warner", city = "seattle"} };



            var peopleInseattle = (from Teacher in Teachers
                                   where Teacher.city == "seattle"
                                   select Teacher.FirstName)
                                   .Concat(from Student in Students
                                           where Student.city == "seattle"
                                           select Student.FirstName);



            foreach (var person in peopleInseattle)
            {
                Console.WriteLine("from seattle city:{0}", person);
            }
            Console.ReadLine();
        }
    }


         public class Product
         {
            public int ProID { get; set; }
            public string ProName { get; set; }
         }


        public class Teacher
        {
           public int ID { get; set; }
           public string FirstName { get; set; }
           public string LastName { get; set; }
            public string city { get; set; }

        }


    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string city { get; set; }

    }
}










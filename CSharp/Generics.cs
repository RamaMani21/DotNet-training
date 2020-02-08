using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList(100);


            items.Add("Hello World");
            items.Add(10);
            items.Add(DateTime.Now);
            items.Add("true");

            foreach (object obj in items)
                Console.WriteLine(obj.ToString());



            List<int> myInts = new List<int>();
            myInts.Add(10);
            myInts.Add(90);
            myInts.Add(70);


            foreach (object obj in myInts)
                Console.WriteLine(obj.ToString());

            List<string> employees = new List<string>() { "rama", "anju" };


            foreach (var emp in employees)
                Console.WriteLine(emp);

            Dictionary<int, string> fruits = new Dictionary<int, string>();
            fruits.Add(1, "kiwi");
            fruits.Add(2, "strawberry");
            fruits.Add(3, "cherry");
            fruits.Add(4, "grapes");


            foreach (KeyValuePair<int, string> kv in fruits)
            {

                Console.WriteLine("Key -> {0}, value -> {1}", kv.Key, kv.Value);

            }

            //deleting an item from the collection

            fruits.Remove(4);
            fruits.Add(4, "lychee");



            foreach (KeyValuePair<int, string> kv in fruits)
            {

                Console.WriteLine("Key -> {0}, value -> {1}", kv.Key, kv.Value);




                SortedDictionary<int, string> gadgets = new SortedDictionary<int, string>();

                gadgets.Add(1, "smart phone");
                gadgets.Add(3, "laptop");
                gadgets.Add(4, "airpods");
                gadgets.Add(2, "tablet");

                foreach (KeyValuePair<int, string> Kv in gadgets)
                {

                    Console.WriteLine("Key -> {0}, value -> {1}", kv.Key, kv.Value);

                }

            }
        }
    }
}

//}



//namespace generics
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> Employees = new List<Employee>();
//            Employee.Add(new Employee() { EmployeeID = 1, EmployeeName = "rama", EmployeeDept = "tech" });
//            Employee.Add(new Employee() { EmployeeID = 2, EmployeeName = "anju", EmployeeDept = "admin" });
//            Employee.Add(new Employee() { EmployeeID = 3, EmployeeName = "dhoni", EmployeeDept = "microsoft" });


//            foreach (var emp in Employees)
//            {
//                Console.WriteLine("EmpID = {0}, Name = {1}, Dept = {2}", emp.EmployeeID, emp.EmployeeName, emp.EmployeeDept);
//            }
//        }
//    }
//        public class Employee
//        {


//            public int EmployeeID
//            {
//                get;
//                set;

//            }

//            public string EmployeeName
//            {
//                get;
//                set;

//            }

//            public string EmployeeDept
//            {
//                get;
//                set;

//            }


//            public void ShowData()
//            {
//            return string.Format("");
//            }


//        }




//            //employee1.Add("rama");
//            //employee1.Add(1);
//            //employee1.Add("tech");

//            //foreach (object obj in employee1)
//            //    Console.WriteLine(obj.ToString());


//            //Employee emp = new Employee();
//            //Employee emp1 = new Employee(1, "rama", "tech");





//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp1 = new Employee(1, "rama", 2, "Admin");
            Employee emp2 = new Employee(2, "anju", 3, "Technical");


            emp1.ShowData();
            emp2.ShowData();

            Product prd = new Product() { ProductID = 1, ProductName = "Badamdrink", Price = 95.00, Quantity = "500ml" };
            prd.ShowData();

            Customer custom = new Customer() { CustomerID=1,Customername= "rama", CustomerCountry="swiss"};
           
            custom.ShowData();
           
        }
    }

    public class Employee
    {
        int empid;
        string empname;
        short deptid;
        string deptname;


        public Employee()        //default constructor
        { }


        public Employee(int eid, string ename, short did, string dname)             //constructor with four parameters
        {

            empid = eid;
            empname = ename;
            deptid = did;
            deptname = dname;

        }

        public void ShowData()
        {

            Console.WriteLine("EmpID={0}", empid);
            Console.WriteLine("Empname={0}", empname);
            Console.WriteLine("deptID={0}", deptid);
            Console.WriteLine("deptname={0}", deptname);



        }


    }
}





public class Product
{
    int pid;


    //defining properties for the class
    public int ProductID
    {
        get { return pid; }
        set { pid = value; }
    }
    //Automatic properties, compiler does the implementation here
    public string ProductName
    {
        get;
        set;
    }
    public double Price
    {
        get;
        set;
    }
    public string Quantity
    {
        get;
        set;
    }
    public void ShowData()
    {
        Console.WriteLine("ProductID ={0}", ProductID);
        Console.WriteLine("ProductName ={0}", ProductName);
        Console.WriteLine("Price ={0}", Price);
        Console.WriteLine("Quantity ={0}", Quantity);

    }
}




public class Customer
{
    int cid;

    public int CustomerID
    {
        get { return cid; }
        set { cid = value; }
    }

    public string Customername
    {
        get;
        set;
    }

    public string CustomerCountry
    {
        get;
        set;
    }

    public void ShowData()
    {

        Console.WriteLine("CustomerID={0}", CustomerID);
        Console.WriteLine("Customername={0}", Customername);
        Console.WriteLine("CustomerCountry={0}", CustomerCountry);
    }
}
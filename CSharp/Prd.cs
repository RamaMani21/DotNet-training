using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using product1;


namespace prd1
{
    class Program
    {
        static void Main(string[] args)
        {
            customer prd = new customer() { ProductID = 1, ProductName = "mobile", ProductPrice = "15000" };

            var prddata = prd.showData();
           
            Console.WriteLine("ProductID:{0}, ProductName:{1},ProductPrice:{2}", ProductID, ProductName , ProductPrice);

            Console.ReadKey();

        }
    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product1
{
    public class customer
    {
        public int ProID { get; set; }
        public string ProName { get; set; }
        public string ProPrice { get; set; }


        
        public void ShowInfo()
        {
            Console.WriteLine("ProductID: {0}, ProductName = {1}, ProductPrice = {2}", ProID, ProName, ProPrice);

        }
    }
}


    


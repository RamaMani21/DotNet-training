using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingcomponent
{
    public class Savingsbank
    {
        public int Balance { get; }
        


        public double GetSimpleInterest(double pr, int td, float rt);

        {
            double si = (pr * td * rt) / 100;
            return si;
        }

        public double GetBalance(double bal, double si)

        {

            return balance;

        }

         public string ShowData()

         {
            return string.Format("BankAccountno={0}, ClientName={1}", bankaccountno, clientname);
         }
     }
}



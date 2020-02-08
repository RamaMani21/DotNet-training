using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankcomponent
{
    public class savingsbank
    {
        public double principleamount { get; set; }

        public float time { get; set; }
        public float rate { get; set; }

        public double GetSimpleInterest(double p, float t, float r)
        {
            double si = (p * t * r) / 100;
            return si;
        }
        public double Balance(double si)
        {
            double ta = principleamount + si;

            return ta;
        }

        public void ShowData()
        {
            Console.WriteLine("principleamount = {0},time={1}, rate={2}", principleamount, time, rate);

        }

    }
}

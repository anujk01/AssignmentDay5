using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class QuotientRemainder
    {
        public void CheckQuotientRemainder()
        {
            Console.WriteLine("enter the value of dividend and divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int dividend = Convert.ToInt32(Console.ReadLine());
            double quotient = dividend / divisor;
            double remainder = dividend % divisor;
            Console.WriteLine("Quotient=" + quotient + "\n Remainder=" + remainder);
        }
    }
}
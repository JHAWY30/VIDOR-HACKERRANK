using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInd_Digits
{
    internal class Program
    {
        public static int findDigits(int n)
        {
            int count = 0;
            int original = n;

            while (n > 0)
            {
                int digit = n % 10;  
                if (digit != 0 && original % digit == 0)
                {
                    count++;
                }
                n /= 10; 
            }
            return count;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics_shop
{
    internal class Program
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxSpent = -1;

            foreach (int k in keyboards)
            {
                foreach (int d in drives)
                {
                    int total = k + d;
                    if (total <= b && total > maxSpent)
                    {
                        maxSpent = total;
                    }
                }
            }

            return maxSpent;
        }
    }
}
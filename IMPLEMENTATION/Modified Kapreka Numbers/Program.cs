using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modified_Kapreka_Numbers
{
    internal class Program
    {

        public static void kaprekarNumbers(int p, int q)
        {
            List<long> kaprekars = new List<long>();

            for (long n = p; n <= q; n++)
            {
                long sq = n * n;
                string s = sq.ToString();
                int d = n.ToString().Length;


                string rightStr = s.Length >= d ? s.Substring(s.Length - d) : s;
                string leftStr = s.Length > d ? s.Substring(0, s.Length - d) : "0";

                long left = long.Parse(leftStr);
                long right = long.Parse(rightStr);

                if (left + right == n)
                    kaprekars.Add(n);
            }

            if (kaprekars.Count > 0)
                Console.WriteLine(string.Join(" ", kaprekars));
            else
                Console.WriteLine("INVALID RANGE");
        }
    }



    class Solution
    {
        public static void Main(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            Result.kaprekarNumbers(p, q);
        }
    }

}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate_Feast
{
    internal class Program
    {
        public static int chocolateFeast(int n, int c, int m)
        {
            int chocolates = n / c;
            int wrappers = chocolates;

            while (wrappers >= m)
            {
                int extra = wrappers / m;
                chocolates += extra;
                wrappers = extra + (wrappers % m);
            }

            return chocolates;
        }

    }



    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int c = Convert.ToInt32(firstMultipleInput[1]);

                int m = Convert.ToInt32(firstMultipleInput[2]);

                int result = Result.chocolateFeast(n, c, m);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }


}

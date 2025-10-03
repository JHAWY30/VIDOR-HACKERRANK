using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Day_at_the_MOvies
{
    internal class Program
    {
        public static int beautifulDays(int i, int j, int k)
        {

            int count = 0;
            for (int day = i; day <= j; day++)
            {
                int rev = ReverseNumber(day);
                if (Math.Abs(day - rev) % k == 0)
                {
                    count++;
                }
            }
            return count;

        }
        static int ReverseNumber(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int i = Convert.ToInt32(firstMultipleInput[0]);

            int j = Convert.ToInt32(firstMultipleInput[1]);

            int k = Convert.ToInt32(firstMultipleInput[2]);

            int result = Result.beautifulDays(i, j, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

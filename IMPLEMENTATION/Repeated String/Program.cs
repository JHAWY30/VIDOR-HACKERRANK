using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeated_String
{
    internal class Program
    {
        public static long repeatedString(string s, long n)

        {
            // count 'a' in the given string
            long countA = 0;
            foreach (char c in s)
                if (c == 'a') countA++;

            long fullRepeats = n / s.Length;
            long remainder = n % s.Length;

            long total = countA * fullRepeats;

            for (int i = 0; i < remainder; i++)
            {
                if (s[i] == 'a')
                    total++;
            }

            return total;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.repeatedString(s, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

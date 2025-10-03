using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIcking_Numbers
{
    internal class Program
    {
        public static int pickingNumbers(List<int> a)
        {
            int maxLength = 0;           
            int[] freq = new int[101];
            foreach (int num in a)
            {
                freq[num]++;
            }
            for (int i = 1; i <= 100; i++)
            {
                int length = freq[i] + freq[i - 1];
                if (length > maxLength)
                {
                    maxLength = length;
                }
            }

            return maxLength;
        }
    }



    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.pickingNumbers(a);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
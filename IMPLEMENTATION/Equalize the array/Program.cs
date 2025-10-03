using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equalize_the_array
{
    internal class Program
    {
        public static int equalizeArray(List<int> arr)
        {
            int maxFreq = 0;

            foreach (int num in arr)
            {
                int freq = arr.Count(x => x == num);
                if (freq > maxFreq)
                    maxFreq = freq;
            }

            return arr.Count - maxFreq;
        }
    }
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.equalizeArray(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

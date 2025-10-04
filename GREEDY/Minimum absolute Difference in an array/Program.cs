using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_absolute_Difference_in_an_array
{
    internal class Program
    {
        public static int minimumAbsoluteDifference(List<int> arr)
        {
            arr.Sort();
            int minDiff = int.MaxValue;

            for (int i = 1; i < arr.Count; i++)
            {
                int diff = Math.Abs(arr[i] - arr[i - 1]);
                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }
            return minDiff;
        }

    }



    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.minimumAbsoluteDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

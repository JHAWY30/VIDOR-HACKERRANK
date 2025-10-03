using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Number
{
    internal class Program
    {
        public static List<int> closestNumbers(List<int> arr)
        {

            arr.Sort();
            int minDiff = int.MaxValue;
            List<int> result = new List<int>();


            for (int i = 0; i < arr.Count - 1; i++)
            {
                int diff = arr[i + 1] - arr[i];

                if (diff < minDiff)
                {
                    minDiff = diff;
                    result.Clear();
                    result.Add(arr[i]);
                    result.Add(arr[i + 1]);
                }
                else if (diff == minDiff)
                {
                    result.Add(arr[i]);
                    result.Add(arr[i + 1]);
                }
            }

            return result;
        }
    }


    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.closestNumbers(arr);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

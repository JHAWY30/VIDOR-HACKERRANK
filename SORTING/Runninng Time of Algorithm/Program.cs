using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runninng_Time_of_Algorithm
{
    internal class Program
    {
        public static int runningTime(List<int> arr)
        {
            int shifts = 0;
            int n = arr.Count;

            for (int i = 1; i < n; i++)
            {
                int value = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    shifts++;
                    j--;
                }

                arr[j + 1] = value;
            }

            return shifts;
        }

    }


    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.runningTime(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

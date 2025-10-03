using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sort_2
{
    internal class Program
    {
        public static List<int> countingSort(List<int> arr)
        {
            int[] counts = new int[100]; // range 0-99

            foreach (int num in arr)
            {
                counts[num]++;
            }

            List<int> sorted = new List<int>();
            for (int i = 0; i < counts.Length; i++)
            {
                for (int j = 0; j < counts[i]; j++)
                {
                    sorted.Add(i);
                }
            }

            return sorted;
        }
    }



    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.countingSort(arr);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }


}

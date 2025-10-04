using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Permutation
{
    internal class Program
    {
        public static List<int> largestPermutation(int k, List<int> arr)
        {
            int n = arr.Count;
            Dictionary<int, int> pos = new Dictionary<int, int>();

            // map value -> index
            for (int i = 0; i < n; i++)
            {
                pos[arr[i]] = i;
            }

            for (int i = 0; i < n && k > 0; i++)
            {
                int correctVal = n - i;
                if (arr[i] == correctVal) continue;

                int idx = pos[correctVal];

                int temp = arr[i];
                arr[i] = arr[idx];
                arr[idx] = temp;

                pos[temp] = idx;
                pos[correctVal] = i;

                k--;
            }
            return arr;
        }
    }



    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.largestPermutation(k, arr);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

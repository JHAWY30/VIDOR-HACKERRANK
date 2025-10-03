using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cut_the_Stick
{
    internal class Program
    {
        public static List<int> cutTheSticks(List<int> arr)
        {
            List<int> result = new List<int>();
            Array.Sort(arr);

            int n = arr.Count;
            int i = 0;

            while (i < n)
            {
                result.Add(n - i);  
                int current = arr[i];


                while (i < n && arr[i] == current)
                {
                    i++;
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

            List<int> result = Result.cutTheSticks(arr);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

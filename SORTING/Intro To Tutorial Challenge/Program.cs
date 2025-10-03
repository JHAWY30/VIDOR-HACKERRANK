using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_To_Tutorial_Challenge
{
    internal class Program
    {
        public static int introTutorial(int V, List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == V)
                    return i;
            }
            return -1;
        }
    }


    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int V = Convert.ToInt32(Console.ReadLine().Trim());

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.introTutorial(V, arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

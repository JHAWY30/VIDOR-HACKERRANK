using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Perimeter_Triangle
{
    internal class Program
    {
        public static List<int> maximumPerimeterTriangle(List<int> sticks)
        {
            sticks.Sort();
            int n = sticks.Count;

            for (int i = n - 1; i >= 2; i--)
            {
                int a = sticks[i - 2];
                int b = sticks[i - 1];
                int c = sticks[i];

                if (a + b > c)
                {
                    return new List<int> { a, b, c };
                }
            }

            return new List<int> { -1 };
        }
    }



    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> sticks = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sticksTemp => Convert.ToInt32(sticksTemp)).ToList();

            List<int> result = Result.maximumPerimeterTriangle(sticks);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Hurdle_Race
{
    internal class Program
    {
        public static int hurdleRace(int k, List<int> height)
        {
            int maxHurdle = height.Max();
            return Math.Max(0, maxHurdle - k);
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

            List<int> height = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();

            int result = Result.hurdleRace(k, height);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
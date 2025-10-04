using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marc_s_Cakewalk
{
    internal class Program
    {
        public static long marcsCakewalk(List<int> calorie)
        {
            calorie.Sort();
            calorie.Reverse();
            long total = 0;

            for (int i = 0; i < calorie.Count; i++)
            {
                total += (long)calorie[i] * (1L << i);
            }
            return total;
        }

    }



    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> calorie = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(calorieTemp => Convert.ToInt32(calorieTemp)).ToList();

            long result = Result.marcsCakewalk(calorie);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

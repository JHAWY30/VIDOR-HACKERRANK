using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angry_Professor
{
    internal class Program
    {
        public static string angryProfessor(int k, List<int> a)
        {
            int onTime = a.Count(t => t <= 0);
            return (onTime >= k) ? "NO" : "YES";
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int k = Convert.ToInt32(firstMultipleInput[1]);

                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                string result = Result.angryProfessor(k, a);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

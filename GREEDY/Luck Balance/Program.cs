using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luck_Balance
{
    internal class Program
    {
        public static int luckBalance(int k, List<List<int>> contests)
        {
            int luck = 0;
            List<int> important = new List<int>();

            foreach (var contest in contests)
            {
                int L = contest[0];
                int T = contest[1];

                if (T == 0)
                {

                    luck += L;
                }
                else
                {
                    important.Add(L);
                }
            }
            important.Sort();
            important.Reverse();

            for (int i = 0; i < important.Count; i++)
            {
                if (i < k) luck += important[i];
                else luck -= important[i];
            }

            return luck;
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

            List<List<int>> contests = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                contests.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(contestsTemp => Convert.ToInt32(contestsTemp)).ToList());
            }

            int result = Result.luckBalance(k, contests);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

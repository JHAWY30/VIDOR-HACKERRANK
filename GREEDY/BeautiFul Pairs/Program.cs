using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautiFul_Pairs
{
    internal class Program
    {
        public static int beautifulPairs(List<int> A, List<int> B)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int num in A)
            {
                if (!freq.ContainsKey(num)) freq[num] = 0;
                freq[num]++;
            }

            int matches = 0;
            foreach (int num in B)
            {
                if (freq.ContainsKey(num) && freq[num] > 0)
                {
                    matches++;
                    freq[num]--;
                }
            }

            if (matches == A.Count) return matches - 1;
            return matches + 1;
        }
    }


    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

            List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

            int result = Result.beautifulPairs(A, B);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

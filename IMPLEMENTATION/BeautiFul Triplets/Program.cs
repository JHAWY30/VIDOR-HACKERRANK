using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautiFul_Triplets
{
    internal class Program
    {
        public static int beautifulTriplets(int d, List<int> arr)
        {
            HashSet<int> set = new HashSet<int>(arr);
            int count = 0;

            foreach (int a in arr)
            {
                if (set.Contains(a + d) && set.Contains(a + 2 * d))
                {
                    count++;
                }
            }
            return count;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.beautifulTriplets(d, arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }


}

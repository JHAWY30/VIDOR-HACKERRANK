using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viral_Advertiment
{
    internal class Program
    {
        public static int viralAdvertising(int n)
        {
            int shared = 5;
            int cumulative = 0;

            for (int day = 0; day < n; day++)
            {
                int liked = shared / 2;
                cumulative += liked;
                shared = liked * 3;
            }
            return cumulative;
        }
    }



    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.viralAdvertising(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

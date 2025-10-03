using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween_Sale
{
    internal class Program
    {
        public static int howManyGames(int p, int d, int m, int s)
        {
            int games = 0;
            int currentPrice = p;

            while (s >= currentPrice)
            {
                s -= currentPrice;
                games++;
                currentPrice = Math.Max(m, currentPrice - d);
            }

            return games;
        }
    }



    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int p = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            int m = Convert.ToInt32(firstMultipleInput[2]);

            int s = Convert.ToInt32(firstMultipleInput[3]);

            int answer = Result.howManyGames(p, d, m, s);

            textWriter.WriteLine(answer);

            textWriter.Flush();
            textWriter.Close();
        }
    }


}

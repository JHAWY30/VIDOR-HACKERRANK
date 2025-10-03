using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale_by_Match
{
    internal class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            Dictionary<int, int> colorCount = new Dictionary<int, int>();
            int pairs = 0;

            foreach (int sock in ar)
            {
                if (!colorCount.ContainsKey(sock))
                    colorCount[sock] = 0;
                colorCount[sock]++;
            }

            foreach (var count in colorCount.Values)
            {
                pairs += count / 2;
            }

            return pairs;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(sockMerchant(n, ar));
        }
    }
}
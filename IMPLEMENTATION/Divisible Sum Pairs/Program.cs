using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_Sum_Pairs
{
    internal class Program
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static void Main(String[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            int n = int.Parse(firstLine[0]);
            int k = int.Parse(firstLine[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }
    }

}



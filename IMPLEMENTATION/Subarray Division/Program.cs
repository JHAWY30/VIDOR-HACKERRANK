using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subarray_Division
{
    internal class Program
    {
        static int Birthday(int[] s, int d, int m)
        {
            int count = 0;
            for (int i = 0; i <= s.Length - m; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += s[i + j];
                }
                if (sum == d)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] s = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int d = dm[0], m = dm[1];

            Console.WriteLine(Birthday(s, d, m));
        }
    }
}
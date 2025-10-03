using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manasa_and_stones
{
    internal class Program
    {
        public static List<int> stones(int n, int a, int b)
        {
            HashSet<int> results = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int value = i * b + (n - 1 - i) * a;
                results.Add(value);
            }

            return results.OrderBy(x => x).ToList();
        }

        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < T; t++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                List<int> result = stones(n, a, b);
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
} 

   



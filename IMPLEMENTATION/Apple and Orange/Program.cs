using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple_and_Orange
{
    internal class Program
    {
        static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int applesOnHouse = apples.Select(d => a + d).Count(pos => pos >= s && pos <= t);
            int orangesOnHouse = oranges.Select(d => b + d).Count(pos => pos >= s && pos <= t);

            Console.WriteLine(applesOnHouse);
            Console.WriteLine(orangesOnHouse);
        }

        static void Main(string[] args)
        {
            var st = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int s = st[0], t = st[1];

            var ab = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int a = ab[0], b = ab[1];

            var mn = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int m = mn[0], n = mn[1];

            int[] apples = Console.ReadLine().Trim().Split().Where(x => x != "").Select(int.Parse).ToArray();
            int[] oranges = Console.ReadLine().Trim().Split().Where(x => x != "").Select(int.Parse).ToArray();

            // In case the arrays could be longer/shorter than m/n, we still use whatever was read.
            CountApplesAndOranges(s, t, a, b, apples, oranges);
        }
    } 
}
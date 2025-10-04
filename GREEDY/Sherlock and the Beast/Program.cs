using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sherlock_and_the_Beast
{
    internal class Program
    {
        static void decentNumber(int n)
        {
            int fives = n;

            // Reduce fives until divisible by 3
            while (fives % 3 != 0)
            {
                fives -= 5;
            }

            if (fives < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                int threes = n - fives;
                Console.WriteLine(new string('5', fives) + new string('3', threes));
            }
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                decentNumber(n);
            }
        }
    }

}

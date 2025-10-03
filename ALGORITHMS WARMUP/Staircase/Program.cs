using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    internal class Program
    {
            static void staircase(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    string spaces = new string(' ', n - i);
                    string hashes = new string('#', i);
                    Console.WriteLine(spaces + hashes);
                }
            }

            static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                staircase(n);
            }
    }
}
    


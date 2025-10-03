using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Line_Jump
{
    internal class Program
    {
        static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 == v2)
                return x1 == x2 ? "YES" : "NO";

            // Check divisibility and positive n
            if ((x2 - x1) % (v1 - v2) == 0 && (x2 - x1) / (v1 - v2) >= 0)
                return "YES";

            return "NO";
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int x1 = int.Parse(input[0]);
            int v1 = int.Parse(input[1]);
            int x2 = int.Parse(input[2]);
            int v2 = int.Parse(input[3]);

            Console.WriteLine(Kangaroo(x1, v1, x2, v2));
        }
    }

}

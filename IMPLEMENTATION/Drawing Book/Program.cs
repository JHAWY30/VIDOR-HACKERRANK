using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Book
{
    internal class Program
    {
        static int pageCount(int n, int p)
        {
            int fromFront = p / 2;       
            int fromBack = (n / 2) - (p / 2);          
            return Math.Min(fromFront, fromBack);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // total pages
            int p = Convert.ToInt32(Console.ReadLine()); // target page

            int result = pageCount(n, p);
            Console.WriteLine(result);
        }
    }
}
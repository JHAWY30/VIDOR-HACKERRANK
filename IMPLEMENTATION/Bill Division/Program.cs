using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Division
{
    internal class Program
    {
        static void bonAppetit(int[] bill, int k, int b)
        {
            int total = bill.Sum();
            int fairShare = (total - bill[k]) / 2;

            if (b == fairShare)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(b - fairShare);
        }

        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            int n = int.Parse(firstLine[0]);
            int k = int.Parse(firstLine[1]);

            int[] bill = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int b = int.Parse(Console.ReadLine());

            bonAppetit(bill, k, b);
        }
    }

}
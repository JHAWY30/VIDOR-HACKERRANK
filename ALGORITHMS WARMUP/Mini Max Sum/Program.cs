using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Max_Sum
{
    internal class Program
    {
        static void miniMaxSum(int[] arr)
        {
            long total = 0;
            foreach (int num in arr)
                total += num;

            long min = total - arr.Max();
            long max = total - arr.Min();

            Console.WriteLine($"{min} {max}");
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            miniMaxSum(arr);
        }
    }
}
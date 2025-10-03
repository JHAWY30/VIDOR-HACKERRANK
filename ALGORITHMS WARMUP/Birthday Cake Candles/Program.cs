using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cake_Candles
{
    internal class Program
    {
        static int birthdayCakeCandles(int[] candles)
        {
            int tallest = candles.Max();
            int count = candles.Count(c => c == tallest);
            return count;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] candles = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(birthdayCakeCandles(candles));
        }
    } 
}
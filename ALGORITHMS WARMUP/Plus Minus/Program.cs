using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    internal class Program
    {
        static void PlusMinusstatic(int[] arr)
        {
            int n = arr.Length;
            int pos = 0, neg = 0, zero = 0;

            foreach (int num in arr)
            {
                if (num > 0)
                    pos++;
                else if (num < 0)
                    neg++;
                else
                    zero++;
            }
            Console.WriteLine(((double)pos / n).ToString("F6"));
            Console.WriteLine(((double)neg / n).ToString("F6"));
            Console.WriteLine(((double)zero / n).ToString("F6"));
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            PlusMinus(arr);
        }
    }
   
}
    


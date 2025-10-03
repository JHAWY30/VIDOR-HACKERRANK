using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Very_Big_Sum
{
    internal class Program
    {
            class Solution
        { 
            static long AVeryBigSum(long[] arr)
            {
                long sum = 0;
                foreach (long num in arr)
                {
                    sum += num;
                }
                return sum;
            }

            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());

                string[] arrInput = Console.ReadLine().Split(' ');
                long[] arr = Array.ConvertAll(arrInput, long.Parse);

                
                long result = AVeryBigSum(arr);            
                Console.WriteLine(result);
            }
        }

    }
}


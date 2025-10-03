using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migratory_Birds
{
    internal class Program
    {
 static int migratoryBirds(int[] arr)
        {
            int[] counts = new int[6]; 
            foreach (int bird in arr)
            {
                counts[bird]++;
            }

            int maxCount = counts.Max();
            for (int i = 1; i <= 5; i++)
            {
                if (counts[i] == maxCount)
                {
                    return i;
                }
            }
            return -1; 
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(migratoryBirds(arr));
        }
    }

}
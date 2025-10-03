using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Array_Rotation
{
    internal class Program
    {
        static List<int> circularArrayRotation(int[] a, int k, int[] queries)
        {
            int n = a.Length;
            var result = new List<int>();

            foreach (int q in queries)
            {
                
                int originalIndex = (q - k) % n;
                if (originalIndex < 0) originalIndex += n;  

                result.Add(a[originalIndex]);
            }

            return result;
        }

        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            int n = int.Parse(firstLine[0]);
            int k = int.Parse(firstLine[1]);
            int q = int.Parse(firstLine[2]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                queries[i] = int.Parse(Console.ReadLine());
            }

            List<int> result = circularArrayRotation(a, k, queries);

            foreach (int val in result)
            {
                Console.WriteLine(val);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumping_on_the_Clouds
{
    internal class Program
    {
        static int jumpingOnClouds(int[] c, int k)
        {

            int n = c.Length;
            int energy = 100;
            int pos = 0;

            do
            {
                pos = (pos + k) % n;
                energy -= 1 + 2 * c[pos];
            } while (pos != 0);

            return energy;

        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

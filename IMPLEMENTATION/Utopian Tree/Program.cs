using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopian_Tree
{
    internal class Program
    {
        public static int utopianTree(int n)
        {
            int height = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1) 
                    height *= 2;
                else            
                    height += 1;
            }
            return height;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = Result.utopianTree(n);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

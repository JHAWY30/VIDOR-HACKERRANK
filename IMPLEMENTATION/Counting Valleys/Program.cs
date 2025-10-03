using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Valleys
{
    internal class Program
    {
        public static int countingValleys(int steps, string path)
        {
            int altitude = 0;   
            int valleys = 0;    

            foreach (char step in path)
            {
                if (step == 'U')
                {
                    altitude++;                   
                    if (altitude == 0)
                    {
                        valleys++;
                    }
                }
                else if (step == 'D')
                {
                    altitude--;
                }
            }
            return valleys;
        }

        class Solution
        {
            public static void Main(string[] args)
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int steps = Convert.ToInt32(Console.ReadLine().Trim());

                string path = Console.ReadLine();

                int result = Result.countingValleys(steps, path);

                textWriter.WriteLine(result);

                textWriter.Flush();
                textWriter.Close();
            }
        }
    }
}
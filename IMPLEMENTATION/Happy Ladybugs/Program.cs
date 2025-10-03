using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Ladybugs
{
    internal class Program
    {
        public static string happyLadybugs(string b)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();
            foreach (char c in b)
            {
                if (c != '_')
                {
                    if (!count.ContainsKey(c))
                        count[c] = 0;
                    count[c]++;
                }
            }
            foreach (var kvp in count)
            {
                if (kvp.Value == 1) return "NO";
            }

            if (!b.Contains('_'))
            {
                for (int i = 0; i < b.Length; i++)
                {
                    bool happy = false;
                    if (i > 0 && b[i] == b[i - 1]) happy = true;
                    if (i < b.Length - 1 && b[i] == b[i + 1]) happy = true;
                    if (!happy) return "NO";
                }
                return "YES";
            }
            return "YES";
        }
    }


    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int g = Convert.ToInt32(Console.ReadLine().Trim());

            for (int gItr = 0; gItr < g; gItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                string b = Console.ReadLine();

                string result = Result.happyLadybugs(b);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

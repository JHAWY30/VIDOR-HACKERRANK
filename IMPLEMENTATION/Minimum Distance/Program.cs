using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Distance
{
    internal class Program
    {
        public static int minimumDistances(List<int> a)
        {
            Dictionary<int, int> lastSeen = new Dictionary<int, int>();
            int minDistance = int.MaxValue;

            for (int i = 0; i < a.Count; i++)
            {
                int value = a[i];
                if (lastSeen.ContainsKey(value))
                {
                    int distance = i - lastSeen[value];
                    if (distance < minDistance)
                        minDistance = distance;
                }
                lastSeen[value] = i;
            }

            return (minDistance == int.MaxValue) ? -1 : minDistance;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.minimumDistances(a);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

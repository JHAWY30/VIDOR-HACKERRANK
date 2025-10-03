using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Sorting
{
    internal class Program
    {
        public static List<string> bigSorting(List<string> unsorted)
        {

            unsorted.Sort((a, b) => {
                if (a.Length != b.Length)
                    return a.Length.CompareTo(b.Length);
                return string.Compare(a, b, StringComparison.Ordinal);
            });
            return unsorted;
        }

    }



    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> unsorted = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string unsortedItem = Console.ReadLine();
                unsorted.Add(unsortedItem);
            }

            List<string> result = Result.bigSorting(unsorted);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

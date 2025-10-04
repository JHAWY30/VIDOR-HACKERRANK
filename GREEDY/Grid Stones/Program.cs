using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Stones
{
    internal class Program
    {
        public static string gridChallenge(List<string> grid)
        {

            int n = grid.Count;
            int m = grid[0].Length;

            for (int i = 0; i < grid.Count; i++)
            {
                char[] row = grid[i].ToCharArray();
                Array.Sort(row);
                grid[i] = new string(row);
            }
            // Step 2: check columns
            for (int col = 0; col < m; col++)
            {
                for (int row = 1; row < n; row++)
                {
                    if (grid[row][col] < grid[row - 1][col])
                    {
                        return "NO";
                    }
                }
            }

            return "YES";
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

                List<string> grid = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    string gridItem = Console.ReadLine();
                    grid.Add(gridItem);
                }

                string result = Result.gridChallenge(grid);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

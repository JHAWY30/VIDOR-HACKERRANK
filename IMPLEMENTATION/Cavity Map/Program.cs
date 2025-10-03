using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cavity_Map
{
    internal class Program
    {

        public static List<string> cavityMap(List<string> grid)
        {
            int n = grid.Count;
            char[][] result = new char[n][];

            for (int i = 0; i < n; i++)
                result[i] = grid[i].ToCharArray();

            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 1; j < n - 1; j++)
                {
                    char current = grid[i][j];
                    if (current > grid[i - 1][j] &&
                        current > grid[i + 1][j] &&
                        current > grid[i][j - 1] &&
                        current > grid[i][j + 1])
                    {
                        result[i][j] = 'X';
                    }
                }
            }
            List<string> output = new List<string>();
            for (int i = 0; i < n; i++)
                output.Add(new string(result[i]));

            return output;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            List<string> result = Result.cavityMap(grid);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }


}

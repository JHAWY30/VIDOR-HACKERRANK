using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    internal class Program
    {
        static int DiagonalDifference(int[][] arr)
        {
            int n = arr.Length;
            int primarySum = 0;
            int secondarySum = 0;

            for (int i = 0; i < n; i++)
            {
                primarySum += arr[i][i];          
                secondarySum += arr[i][n - i - 1];   
            }

            return Math.Abs(primarySum - secondarySum);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                arr[i] = Array.ConvertAll(row, int.Parse);
            }

            int result = DiagonalDifference(arr);
            Console.WriteLine(result);
        }
    }
        
}
    


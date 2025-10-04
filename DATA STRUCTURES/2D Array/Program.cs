using System;
using System.Collections.Generic;
class Result
{

    /*
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The Nfunction accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(List<List<int>> arr)
    {
        int maxSum = int.MinValue;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                int currentSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                               + arr[i + 1][j + 1]
                               + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                maxSum = Math.Max(maxSum, currentSum);
            }
        }

        return maxSum;
    } 
}
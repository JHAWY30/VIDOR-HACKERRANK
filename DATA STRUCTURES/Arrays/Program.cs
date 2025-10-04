using System;
using System.Collections.Generic;
class Result
{

    /*
     * Complete the 'reverseArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static List<int> reverseArray(List<int> a)
    {
        List<int> reversed = new List<int>();
        for (int i = a.Count - 1; i >= 0; i--)
        {
            reversed.Add(a[i]);
        }
        return reversed;
    }

}
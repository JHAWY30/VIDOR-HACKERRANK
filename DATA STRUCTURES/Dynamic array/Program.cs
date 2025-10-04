using System.Collections.Generic;

class Result
{

    /*
     * Complete the 'dynamicArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<int> lastAnswers = new List<int>();
        List<List<int>> seqList = new List<List<int>>(new List<int>[n]);
        int lastAns = 0;

        for (int i = 0; i < n; i++)
        {
            seqList[i] = new List<int>();
        }

        foreach (var query in queries)
        {
            int type = query[0];
            int x = query[1];
            int y = query[2];

            int seqIndex = (x ^ lastAns) % n;

            if (type == 1)
            {
                seqList[seqIndex].Add(y);
            }
            else if (type == 2)
            {
                if (seqList[seqIndex].Count > 0)
                {
                    lastAns = seqList[seqIndex][y % seqList[seqIndex].Count];
                    lastAnswers.Add(lastAns);
                }
            }
        }

        return lastAnswers;
    }

}
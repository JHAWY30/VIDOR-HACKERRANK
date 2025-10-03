using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LisaWorkbook
    internal class Program
    {
    public static int workbook(int n, int k, List<int> arr)
    {
        int page = 1;
        int special = 0;

        for (int i = 0; i < n; i++)
        {
            int problems = arr[i];
            for (int p = 1; p <= problems; p += k)
            {
                int start = p;
                int end = Math.Min(p + k - 1, problems);


                if (page >= start && page <= end)
                {
                    special++;
                }
                page++;
            }
        }

        return special;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.workbook(n, k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

}

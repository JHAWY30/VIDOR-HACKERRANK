using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priyanka_and_Toys
{
    internal class Program
    {
        public static int toys(List<int> w)
        {
            w.Sort();
        int containers = 0;
        int i = 0;
        int n = w.Count;

        while (i<n) {
            containers++;
            int limit = w[i] + 4;

            
            while (i<n && w[i] <= limit) {
                i++;
            }
}
return containers;
 }

}



class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> w = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(wTemp => Convert.ToInt32(wTemp)).ToList();

        int result = Result.toys(w);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

}

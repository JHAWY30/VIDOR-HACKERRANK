using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_PDF_viewer
{
    internal class Program
    {

        public static int designerPdfViewer(List<int> h, string word)
        {
            int tallest = 0;
            foreach (char c in word)
            {
                int height = h[c - 'a']; 
                if (height > tallest)
                    tallest = height;
            }
            return tallest * word.Length;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

            string word = Console.ReadLine();

            int result = Result.designerPdfViewer(h, word);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}


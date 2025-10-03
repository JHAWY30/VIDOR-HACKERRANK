using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_and_delete
{
    internal class Program
    {
        static string appendAndDelete(string s, string t, int k)
        {
            int sLen = s.Length;
            int tLen = t.Length;
            int common = 0;

           
            for (int i = 0; i < Math.Min(sLen, tLen); i++)
            {
                if (s[i] == t[i])
                    common++;
                else
                    break;
            }
            int minOps = (sLen - common) + (tLen - common);
            if (k >= sLen + tLen)
            {
                return "Yes";
            }
            else if (k >= minOps && (k - minOps) % 2 == 0)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.appendAndDelete(s, t, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
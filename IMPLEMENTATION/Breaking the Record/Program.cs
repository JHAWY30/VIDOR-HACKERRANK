using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaking_the_Record
{
    internal class Program
    {
        static int[] BreakingRecords(int[] scores)
        {
            int minScore = scores[0];
            int maxScore = scores[0];
            int minCount = 0, maxCount = 0;

            foreach (int score in scores.Skip(1))
            {
                if (score > maxScore)
                {
                    maxScore = score;
                    maxCount++;
                }
                else if (score < minScore)
                {
                    minScore = score;
                    minCount++;
                }
            }

            return new int[] { maxCount, minCount };
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] result = BreakingRecords(scores);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Between_Two_Sets
{
    internal class Program
    {
            static int GCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            static int LCM(int a, int b)
            {
                return (a * b) / GCD(a, b);
            }

            static int GetTotalX(int[] a, int[] b)
            {            
                int lcmA = a.Aggregate((x, y) => LCM(x, y));          
                int gcdB = b.Aggregate((x, y) => GCD(x, y));            
                int count = 0;
                for (int multiple = lcmA; multiple <= gcdB; multiple += lcmA)
                {
                    if (gcdB % multiple == 0)
                        count++;
                }

                return count;
            }

            static void Main(string[] args)
            {
                var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = nm[0], m = nm[1];

                int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();

                Console.WriteLine(GetTotalX(a, b));
            }
        }


    }
}


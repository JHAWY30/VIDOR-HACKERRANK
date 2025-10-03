using System;
using System.Collections.Generic;
using System.IO;
class Solution
{



    // Function to compute the sum of two integers
    static int SolveMeFirst(int a, int b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int result = SolveMeFirst(a, b);

        Console.WriteLine(result);
    }

}

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

}

class Solution
{
    public static void Main(string[] args)
    {
        static int SimpleArraySum(int[] ar)
        {
            int sum = 0;
            foreach (int num in ar)
            {
                sum += num;
            }
            return sum;
        }


        // Read array size
        int n = int.Parse(Console.ReadLine());

        // Read array elements
        string[] arrInput = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(arrInput, int.Parse);

        // Get result
        int result = SimpleArraySum(ar);

        // Print output
        Console.WriteLine(result);
    }
}


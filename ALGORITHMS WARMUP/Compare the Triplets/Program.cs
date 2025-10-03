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

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */



}

class Solution
{
    public static void Main(string[] args)
    {
        static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int alice = 0;
            int bob = 0;

            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                    alice++;
                else if (a[i] < b[i])
                    bob++;

            }

            return new List<int> { alice, bob };
        }


        // Read input
        string[] aInput = Console.ReadLine().Split(' ');
        string[] bInput = Console.ReadLine().Split(' ');

        List<int> a = new List<int>();
        List<int> b = new List<int>();

        foreach (string val in aInput) a.Add(int.Parse(val));
        foreach (string val in bInput) b.Add(int.Parse(val));

        List<int> result = CompareTriplets(a, b);

        Console.WriteLine(string.Join(" ", result));
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innsertion_Sort_Part_1
{
    internal class Program
    {
        public static void insertionSort1(int n, List<int> arr)
        {
            int value = arr[n - 1];
            int i = n - 2;

            while (i >= 0 && arr[i] > value)
            {
                arr[i + 1] = arr[i]; 
                PrintList(arr);
                i--;
            }
            arr[i + 1] = value;
            PrintList(arr);
        }
        public static void PrintList(List<int> arr)
        {

            Console.WriteLine(string.Join(" ", arr));
        }

    }



    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.insertionSort1(n, arr);
        }
    }

}

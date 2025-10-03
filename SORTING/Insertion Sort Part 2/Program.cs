using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort_Part_2
{
    internal class Program
    {
        public static void insertionSort2(int n, List<int> arr)
        {
            for (int i = 1; i < n; i++)
            {
                int value = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = value;
                PrintList(arr);
            }
        }


        public static void PrintList(List<int> arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }



}

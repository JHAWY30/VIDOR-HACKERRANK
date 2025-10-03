using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_the_Programmer
{
    internal class Program
    {

        static string dayOfProgrammer(int year)
        {
            if (year == 1918)
                return "26.09.1918";

            bool isLeap;
            if (year < 1918)
            {
              
                isLeap = (year % 4 == 0);
            }
            else
            {               
                isLeap = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            }
            return isLeap ? $"12.09.{year}" : $"13.09.{year}";
        }

        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(dayOfProgrammer(year));
        }
    }

}

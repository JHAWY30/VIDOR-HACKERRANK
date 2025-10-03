using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Conversion
{
    internal class Program
    {
        static string timeConversion(string s)
        {
            // Extract parts
            string period = s.Substring(s.Length - 2);
            int hour = int.Parse(s.Substring(0, 2));
            string rest = s.Substring(2, 6);

            if (period == "AM")
            {
                if (hour == 12) hour = 0;
            }
            else // PM
            {
                if (hour != 12) hour += 12;
            }

            return hour.ToString("D2") + rest;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(timeConversion(s));
        }
    }
}
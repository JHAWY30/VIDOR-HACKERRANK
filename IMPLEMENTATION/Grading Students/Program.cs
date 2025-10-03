using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Students
{
    internal class Program
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();

            foreach (int grade in grades)
            {
                if (grade < 38)
                {

                    result.Add(grade);
                }
                else
                {
                    int nextMultipleOf5 = ((grade / 5) + 1) * 5;
                    if (nextMultipleOf5 - grade < 3)
                        result.Add(nextMultipleOf5);
                    else
                        result.Add(grade);
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> grades = new List<int>();

            for (int i = 0; i < n; i++)
            {
                grades.Add(Convert.ToInt32(Console.ReadLine()));
            }

            List<int> rounded = GradingStudents(grades);

            foreach (int grade in rounded)
            {
                Console.WriteLine(grade);
            }
        }
    }

}



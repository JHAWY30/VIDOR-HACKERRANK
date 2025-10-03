using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_and_a_Mouse
{
    internal class Program
    {
        static string catAndMouse(int x, int y, int z)
        {
            int distA = Math.Abs(z - x);
            int distB = Math.Abs(z - y);

            if (distA < distB)
                return "Cat A";
            else if (distB < distA)
                return "Cat B";
            else
                return "Mouse C";
        }

    }
}
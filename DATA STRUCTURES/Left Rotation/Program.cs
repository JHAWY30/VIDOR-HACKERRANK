using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_Rotation
{
    internal class Program
    {

        public static List<int> rotateLeft(int d, List<int> arr)
        {
            int n = arr.Count;
            List<int> rotated = new List<int>(new int[n]);

            for (int i = 0; i < n; i++)
            {
                int newIndex = (i - d + n) % n;
                rotated[newIndex] = arr[i];
            }

            return rotated;
        }

    }
}

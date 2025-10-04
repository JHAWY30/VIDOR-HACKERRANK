using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JIm_and_the_Orders
{
    internal class Program
    {
        public static List<int> jimOrders(List<List<int>> orders)
        {
            var orderList = new List<(int time, int id)>();

            for (int i = 0; i < orders.Count; i++)
            {
                int arrival = orders[i][0];
                int duration = orders[i][1];
                int completion = arrival + duration;
                orderList.Add((completion, i + 1)); 
            }  
            orderList.Sort((a, b) =>
            {
                if (a.time == b.time) return a.id.CompareTo(b.id);
                return a.time.CompareTo(b.time);
            });            
            return orderList.Select(x => x.id).ToList();
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> orders = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            orders.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ordersTemp => Convert.ToInt32(ordersTemp)).ToList());
        }

        List<int> result = Result.jimOrders(orders);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}



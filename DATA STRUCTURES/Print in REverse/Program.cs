using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_in_REverse
{
    internal class Program
    {
        public static void reversePrint(SinglyLinkedListNode llist)
        {
            Stack<int> stack = new Stack<int>();
            while (llist != null)
            {
                stack.Push(llist.data);
                llist = llist.next;
            }
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

    }
}
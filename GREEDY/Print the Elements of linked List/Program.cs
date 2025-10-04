using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_the_Elements_of_linked_List
{
    internal class Program
    {
        static void printLinkedList(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Merge_point_of_Two_Lists
{
    internal class Program
    {
        static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            SinglyLinkedListNode a = head1;
            SinglyLinkedListNode b = head2;

            while (a != b)
            {
                a = (a == null) ? head2 : a.next;
                b = (b == null) ? head1 : b.next;
            }

            return a.data;
        }
    }
}

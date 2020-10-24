using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class MergeTwoSortedLists
    {
        public static SinglyLinkedList MergeList(SinglyLinkedList l1, SinglyLinkedList l2)
        {
            if (l1 == null)
                return l2;
            else if (l2 == null)
                return l1;
            //make a copy of dummy so we can return the merged list in the form of dummy.next
            SinglyLinkedList dummy = new SinglyLinkedList(0);
            var curr = dummy;
            while (l1 != null && l2 != null)
            {
                //assign l1 list to current list
                //and assigne left out list to list 1
                if (l1.Value <= l2.Value)
                {
                    curr.Next = l1;
                    l1 = l1.Next;
                }
                else
                {
                    curr.Next = l2;
                    l2 = l2.Next;
                }
                //assign next in current list as current so we can add other values from l1 and l2
                curr = curr.Next;
            }

            if (l1 == null)
                curr.Next = l2;
            else if (l2 == null)
                curr.Next = l1;

            return dummy.Next;
        }

    }
}

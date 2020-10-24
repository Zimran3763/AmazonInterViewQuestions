using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 23. Merge k Sorted Lists
 * You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
   Merge all the linked-lists into one sorted linked-list and return it.
 */
namespace LinkedLists
{
    public class MergeKSortedLists
    {       
        public SinglyLinkedList MergeKLists(SinglyLinkedList [] lists)
        {
            if (lists.Length == 1)
                return lists[0];
            if (lists.Length == 0)
                return null;

            var head = MergeTwoSortedLists.MergeList(lists[0], lists[1]);

            for (int i = 2; i < lists.Length; i++)
            {
                head = MergeTwoSortedLists.MergeList(head, lists[i]);
            }
            return head;
        }
    }
}

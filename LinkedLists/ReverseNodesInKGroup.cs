using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  25. Reverse Nodes in k-Group
 *  Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.
    k is a positive integer and is less than or equal to the length of the linked list. 
    If the number of nodes is not a multiple of k then left-out nodes, in the end, should remain as it is.

    this is not in o(1) space
 */
namespace LinkedLists
{
    //Wanted to do like this
    // 1-->2-->3-->4-->5-->6-->7-->8-->null
    // 3-->2-->1-->6-->5-->4-->7-->8-->null
    public class ReverseNodesInKGroup
    {
        public static SinglyLinkedList ReverseKGroup(SinglyLinkedList head, int k)
        {
            //if there is no group return whole list as it is
            if (k == 0) return head;
            //if head is null means list empty return head
            if (head == null) return head;

            var current = head;
            //there is no previous node of head so it would be null
            SinglyLinkedList previousNode = null;
            //create stack to use k group node in reverse order
            Stack nodeStack = new Stack();
            //use queue to use left out node if list length is not multiple of k 
            Queue queue = new Queue();
            
            while(current!=null)
            {
                
                int count = 0;
                //this while put all node in groups into stack
                while(current!=null && count<k)
                {
                    nodeStack.Push(current);
                    queue.Enqueue(current);
                    current = current.Next;
                    count++;
                }
                
                //this while will use stack to arrange node in reverse order
                while (nodeStack.Count > 0 && count == k)
                {
                    if (previousNode == null)
                    {
                        head = (SinglyLinkedList)nodeStack.Pop();
                        previousNode = head;
                    }
                    else
                    {
                        previousNode.Next = (SinglyLinkedList)nodeStack.Pop();
                        previousNode = previousNode.Next;
                    }
                    queue.Dequeue();
                }
                // if you do not want to reverse last node that which has count less than k then use following while
                // if you remove following while this code also work for reverse all node in k group including left out like below
                // 1-->2-->3-->4-->5-->6-->7-->8-->null
                // 3-->2-->1-->6-->5-->4-->8-->7-->null

                //this while will use if left out node is less than k and arrange as it is
                while (queue.Count > 0)
                {
                    previousNode.Next = (SinglyLinkedList)queue.Dequeue();
                    previousNode = previousNode.Next;

                }
  
            }
            previousNode.Next = null;
            return head;
        }
    }
}

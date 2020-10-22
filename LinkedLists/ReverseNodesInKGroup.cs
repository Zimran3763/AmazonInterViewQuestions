using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    // 1-->2-->3-->4-->5-->null
    // 2-->1-->4-->3-->5-->null
    public class ReverseNodesInKGroup
    {
        public static SinglyLinkedList ReverseKGroup(SinglyLinkedList head, int k)
        {
            var current = head;
            SinglyLinkedList previousNode = null;
            Stack nodeStack = new Stack();
            while(current!=null)
            {
                int count = 0;
                while(current!=null && count<k)
                {
                    nodeStack.Push(current);
                    current = current.Next;
                    count++;
                }
                while (nodeStack.Count > 0)
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
                }
                
            }
            previousNode.Next = null;
            return head;
        }
    }
}

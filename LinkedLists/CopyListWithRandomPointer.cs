using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class CopyListWithRandomPointer
    {
        public static SinglyLinkedList CopyRandomList(SinglyLinkedList head)
        {
            Dictionary<SinglyLinkedList, SinglyLinkedList> dict = new Dictionary<SinglyLinkedList, SinglyLinkedList>();

            //create dummy list and copy it to curr so when we use current it will save all current values in dummy
            SinglyLinkedList dummy = new SinglyLinkedList(Int32.MinValue),
                 cur = dummy,
                 original = head;

            //add dictionary key by orginal list value and 
            //value by orginal val through temp list( temp list will only have value at this time no random pointer)
            while (original != null)
            {
                SinglyLinkedList temp = new SinglyLinkedList(original.Value);

                dict.Add(original, temp);

                original = original.Next;
                cur.Next = temp;
                cur = cur.Next;
                
            }
            //copy head again beause during traversal distroyed original
            original = head;

            //checking original value and assigning dictionary each key a random pointer by using the value of original random pointer as a key and
            // assign the value of that key to the key of dictionary randompointer
            // for example dic[1] = 1 but currently has no random pointer
            // we will dic[original.random] which is dic[3] that has 3 value and it would be random pointer 
            // so dic[1].randompointer = 3
            while (original != null)
            {
                if (original.RandomPointer == null)
                    dict[original].RandomPointer = null;
                else
                    dict[original].RandomPointer = dict[original.RandomPointer];

                original = original.Next;
            }

            return dummy.Next;
        }
    }
}

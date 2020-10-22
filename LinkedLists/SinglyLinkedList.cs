using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class SinglyLinkedList
    {
        public int Value { get; set; }
        public SinglyLinkedList Next { get; set; }
        public SinglyLinkedList(int val)
        {
            Value = val;
            Next = null;
        }
    }
}

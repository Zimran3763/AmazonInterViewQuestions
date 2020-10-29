using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueues
{
    public class MinStack
    {
        List<int> minStack;

        public MinStack()
        {
            minStack = new List<int>();
        }

        public void Push(int x)
        {
            minStack.Add(x);
        }

        public void Pop()
        {
            minStack.RemoveAt(minStack.Count - 1);
        }

        public int Top()
        {
            return minStack.Last();
        }

        public int GetMin()
        {
            return minStack.Min();
        }
    }
}

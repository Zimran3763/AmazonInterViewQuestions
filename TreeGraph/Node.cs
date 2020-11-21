using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGraph
{
    public class Node
    {
        public int data;
        public int hd;
        public Node left, right;
        public Node(int d)
        {
            hd = int.MaxValue;
            data = d;
            left = right = null;
        }
    }
}

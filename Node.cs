using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class Node
    {
        public int data;
        public Node left, right;
        public Node(int d)
        {
            data = d;
            left = right = null;
        }
    }
}

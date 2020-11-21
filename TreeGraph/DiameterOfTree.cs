using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGraph
{
    public class DiameterOfTree
    {
        /* Function to find height of a tree */
        public static int height(Node root, int a)
        {
            if (root == null)
                return 0;

            int left_height = height(root.left, a);

            int right_height = height(root.right, a);

            // update the answer, because diameter of a  
            // tree is nothing but maximum value of  
            // (left_height + right_height + 1) for each node  
            a = Math.Max(a, 1 + left_height + right_height);

            return 1 + Math.Max(left_height, right_height);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGraph
{
    public class SumNodeRootToLeafNode
    {
        public static int maxLen;
        public static int maxSum;

        // function to find the sum of nodes on the  
        // longest path from root to leaf node  
        public static void sumOfLongRootToLeafPath(Node root, int sum, int len)
        {
            // if true, then we have traversed a  
            // root to leaf path  
            if (root == null)
            {
                // update maximum length and maximum sum  
                // according to the given conditions  
                if (maxLen < len)
                {
                    maxLen = len;
                    maxSum = sum;
                }
                else if (maxLen == len && maxSum < sum)
                {
                    maxSum = sum;
                }
                return;
            }
            // recur for left subtree  
            sumOfLongRootToLeafPath(root.left, sum + root.data, len + 1);
            sumOfLongRootToLeafPath(root.right, sum + root.data, len + 1);
        }

        // utility function to find the sum of nodes on  
        // the longest path from root to leaf node  
        public static int sumOfLongRootToLeafPathUtil(Node root)
        {
            // if tree is NULL, then sum is 0  
            if (root == null)
            {
                return 0;
            }

            maxSum = int.MinValue;
            maxLen = 0;

            // finding the maximum sum 'maxSum' for the  
            // maximum length root to leaf path  
            sumOfLongRootToLeafPath(root, 0, 0);

            // required maximum sum  
            return maxSum;
        }
    }
}

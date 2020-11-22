using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGraph
{
    public class FindLargestSubtreeSumInATree
    {
        // Helper function to find largest  
        // subtree sum recursively.  
        public static int findLargestSubtreeSumUtil(Node root, int ans)
        {
            // If current node is null then  
            // return 0 to parent node.  
            if (root == null)
            {
                return 0;
            }

            // Subtree sum rooted  
            // at current node.  
            int currSum = root.data + findLargestSubtreeSumUtil(root.left, ans)
                                + findLargestSubtreeSumUtil(root.right, ans);

            // Update answer if current subtree  
            // sum is greater than answer so far.  
            ans = Math.Max(ans, currSum);

            // Return current subtree  
            // sum to its parent node.  
            return currSum;
        }

        // Function to find  
        // largest subtree sum.  
        public static int findLargestSubtreeSum(Node root, int ans)
        {
            // If tree does not exist,  
            // then answer is 0.  
            if (root == null)
            {
                return 0;
            }

            // Call to recursive function  
            // to find maximum subtree sum.  
            findLargestSubtreeSumUtil(root, ans);

            return ans;
        }

    }
}

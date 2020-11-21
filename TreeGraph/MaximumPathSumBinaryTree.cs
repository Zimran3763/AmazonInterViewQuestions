using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGraph
{
    
    public class MaximumPathSumBinaryTree
    {
        public static int  maxPath(Node node)
        {
            var res = new Res();
            res.val = int.MinValue;
            findMaxPathSum(node, res);
            return res.val;
        }
        public static int findMaxPathSum( Node tree, Res res)
        
        {
            if (tree == null)
                return 0;
            //it will keep running until it will not find null
            //then it will check right of the node that has null
            // after returning node value as a max_single 
            //it will go back to right of the node
            // so in below tree when it went through with 3 left of node 8
            // it will go right of node 8 which is 5
            //        10
            //    8       2
            //3      5
            int l = findMaxPathSum(tree.left, res);
            int r = findMaxPathSum(tree.right, res);

            int max_single = Math.Max(Math.Max(l, r) + tree.data, tree.data);
            int Max_top = Math.Max(max_single, l + r + tree.data);
            res.val = Math.Max(res.val, Max_top);
            return max_single;
        }
    }
    public class Res
    {
        public int val;
    }

}

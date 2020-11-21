using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGraph
{
    public class LeafOnSameLevel
    {

        static int leafLevel = 0;
        public static bool SameLevel(Node tree, int level)
        {
            if (tree == null)
                return true;
            if (tree.left == null && tree.right == null)
            {
                //if this is first leafnode
                if (leafLevel == 0)
                {
                    leafLevel = level;
                    return true;
                }
                //check if leaflevel is equal to current level
                return leafLevel == level;
            }
            //check if both left and right level are equal or not
            return SameLevel(tree.left, level + 1) && SameLevel(tree.right, level + 1);
        }
    }
}

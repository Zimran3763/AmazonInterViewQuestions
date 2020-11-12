using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class DepthOfATree
    {
        public static bool IsBalanced(Node treeRoot)
        {

            // a tree with no nodes is superbalanced, since there are no leaves!
            if (treeRoot == null)
            {
                return true;
            }

            var depths = new List<int>(3);  // We short-circuit as soon as we find more than 2

            // Nodes will store pairs of a node and the node's depth
            var nodes = new Stack<Node>();
            int d = 0;
            treeRoot.hd = d;
            nodes.Push(treeRoot);

            while (nodes.Count > 0)
            {
                // Pop a node and its depth from the top of our stack
                var nodeDepthPair = nodes.Pop();
                

                if (nodeDepthPair.left == null && nodeDepthPair.right == null)
                {
                    // Case: we found a leaf

                    // We only care if it's a new depth
                    if (!depths.Contains(nodeDepthPair.hd))
                    {
                        depths.Add(nodeDepthPair.hd);

                        // Two ways we might now have an unbalanced tree:
                        //   1) more than 2 different leaf depths
                        //   2) 2 leaf depths that are more than 1 apart
                        if (depths.Count > 2
                            || (depths.Count == 2 && Math.Abs(depths[0] - depths[1]) > 1))
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    // Case: this isn't a leaf - keep stepping down

                    if (nodeDepthPair.left != null)
                    {
                        nodeDepthPair.left.hd = nodeDepthPair.hd + 1;
                        nodes.Push(nodeDepthPair.left);
                    }

                    if (nodeDepthPair.right != null)
                    {
                        nodeDepthPair.right.hd = nodeDepthPair.hd + 1;
                        nodes.Push(treeRoot.right);
                    }
                }
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Given a list of unique integers nums, construct a BST from it (you need to insert nodes one-by-one with the given order to get the BST) and find the distance between two nodes node1 and node2. Distance is the number of edges between two nodes. If any of the given nodes does not appear in the BST, return -1.

Example 1:

Input: nums = [2, 1, 3], node1 = 1, node2 = 3
Output: 2
Explanation:
     2
   /   \
  1     3
 */
namespace AmazonOnlineAssessment
{
    public class DistanceBetweenNodesInBST
    {
        #region Create BST using given array 
        public static Node buildBST(int[] nums, int node1, int node2)
        {
            Node root = null;
            bool found1 = false;
            bool found2 = false;
            foreach (int val in nums)
            {
                if (val == node1) found1 = true;
                if (val == node2) found2 = true;

                Node node = new Node(val);
                //if root is null then set the value as root value
                //otherwise add the value to BST right or left 
                if (root == null)
                {
                    root = node;
                    continue;
                }               
                addToBST(root, node);
            }
            if (!found1 || !found2) return null;
            return root;
        }
        public static void addToBST(Node root, Node node)
        {
            for (Node curr = root; true;)
            {
                //if node value is less than current root value then add it to left if left is nul
                //else set it to current node 
                if (curr.Value > node.Value)
                {
                    if (curr.Left == null)
                    {
                        curr.Left = node;
                        //after setting it up come out from the loop
                        break;
                    }
                    else
                    {
                        curr = curr.Left;
                    }
                }
                else
                {
                    if (curr.Right == null)
                    {
                        curr.Right = node;
                        break;
                    }
                    else
                    {
                        //set this as current node
                        curr = curr.Right;
                    }
                }
            }
        }
        #endregion
        public static  int bstDistance(int[] nums, int node1, int node2)
        {
            //build bst
            Node root = buildBST(nums, node1, node2);

            if (root == null) return -1;
            //lowest ansector of given two node node1 and node2
            Node lowest = lca(root, node1, node2);
            // 1 +1 =2
            return getDistance(lowest, node1) + getDistance(lowest, node2);
        }

        private static int getDistance(Node src, int dest)
        {
            //if destination node value and source value is same then distance is 0
            if (src.Value == dest) return 0;
            //set left of source node as node( 2>1)
            Node node = src.Left;

            //if source node value is less than the destination node then set it as source right as node
            //(2<3)
            if (src.Value < dest)
            {
                node = src.Right;
            }
            //add one on each node traversal 
            return 1 + getDistance(node, dest);
        }
        public static Node lca(Node root, int node1, int node2)
        {
            while (true)
            {
                //if current root value is greater than both node then we will go to left and set the left node as root
                if (root.Value > node1 && root.Value > node2)
                {
                    root = root.Left;
                }
                else if (root.Value < node1 && root.Value < node2)
                {
                    root = root.Right;
                }
                else
                {
                    //if avobe two condition does not met then this is the root for node1 and node2
                    return root;
                }
            }
        }

        public class Node
        {
            public Node Left;
            public Node Right;
            public int Value;

            public Node(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }
    }
}

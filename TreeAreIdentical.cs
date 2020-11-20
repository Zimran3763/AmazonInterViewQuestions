using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class TreeAreIdentical
    {
        //If two tree are same
        public static bool TreeAreSame(Node tree1, Node tree2)
        {
            if (tree1 == null && tree2 == null)
                return true;
            if(tree1!=null && tree2!=null)
            {
                return (tree1.data == tree2.data && TreeAreSame(tree1.left, tree2.left) && TreeAreSame(tree1.right, tree2.right));
            }
            return false;
        }
        //Tree is mirror or not 
        public static bool IsMirror(Node tree1, Node tree2)
        {
            if (tree1 == null && tree2 == null)
                return true;
            if (tree1 == null || tree2 == null)
                return false;
            return (tree1.data == tree2.data && TreeAreSame(tree1.left, tree2.right) && TreeAreSame(tree1.right, tree2.left));
        }
        /*
         * public boolean isSymmetric(TreeNode root) {
                Queue<TreeNode> q = new LinkedList<>();
                q.add(root);
                q.add(root);
                while (!q.isEmpty()) {
                    TreeNode t1 = q.poll();
                    TreeNode t2 = q.poll();
                    if (t1 == null && t2 == null) continue;
                    if (t1 == null || t2 == null) return false;
                    if (t1.val != t2.val) return false;
                    q.add(t1.left);
                    q.add(t2.right);
                    q.add(t1.right);
                    q.add(t2.left);
                }
                return true;
            }
         */
        //if a sub tree is in main tree
        public static bool TreeIsASubtree(Node mainTree, Node subTree)
        {
            if(subTree == null) return true;
            if(mainTree == null) return false;
            if (TreeAreSame(mainTree, subTree))
                return true;

            return TreeIsASubtree(mainTree.left, subTree) || TreeIsASubtree(mainTree.right, subTree);

        }
    }
}

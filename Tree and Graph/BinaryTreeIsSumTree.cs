using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class BinaryTreeIsSumTree
    {
        public static bool TreeSum(Node tree)
        {
            //if tree is null then it's sum tree
            if (tree == null)
                return true;

            //if leaf node is null then tree is sum tree
            if (tree.left == null && tree.right == null)
                return true;

            //add all left and right tree
            int leftSum = Add(tree.left);
            int rightSum = Add(tree.right);

            //check if tree data is equal to left and right
            if (tree.data == leftSum + rightSum)
            {
                if (TreeSum(tree.left) && TreeSum(tree.right)) 
                return true;
            }
            return false;
        }
        //helper function to add all node
        private static int Add(Node tree)
        {
            if (tree == null)
                return 0;
            int total = tree.data + Add(tree.left) + Add(tree.right);
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class TreeSum
    {
        public static int ToSumTree(Node tree)
        {
            if(tree == null)
            {
                return 0;
            }

            int oldValue = tree.data;

            tree.data = ToSumTree(tree.left) 
                + ToSumTree(tree.right); 

            
            return tree.data + oldValue;
                                                                    }
        public static void PrintInorderTraversal(Node tree)
        {
            if (tree == null)
                return;
            PrintInorderTraversal(tree.left);
            Console.Write(tree.data + " ");
            PrintInorderTraversal(tree.right);
        }
    }
}

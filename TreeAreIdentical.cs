using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class TreeAreIdentical
    {
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
    }
}

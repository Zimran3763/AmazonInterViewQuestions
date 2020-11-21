using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class MirrorOFATree
    {
        public static Node Mirrorify(Node root)
        {
            if (root == null)
            {
                return null;

            }
            // Create new mirror node from original tree node  
            Node mirror = new Node(root.data);
            mirror.right = Mirrorify(root.left);
            mirror.left = Mirrorify(root.right);
            return mirror;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class BoundryTraversal
    {
        public static void GetLeftBoundryNodes(Node node)
        {
            if (node == null) return;
            if(node.left!=null)
            {
                Console.Write(node.data + " ");
                GetLeftBoundryNodes(node.left);
            }
            else if(node.right!=null)
            {
                Console.Write(node.data + " ");
                GetLeftBoundryNodes(node.right);
            }
        }
        public static void GetLevesNodes(Node node)
        {
            if (node == null) return;
            if(node.left == null & node.right == null)
            {
                Console.Write(node.data + " ");
            }
        }
        public static void GetRightBoundryNodes(Node node)
        {
            if (node == null) return;
            if (node.right != null)
            {
                
                GetLeftBoundryNodes(node.right);
                Console.Write(node.data + " ");
            }
            else if (node.left != null)
            {
                GetLeftBoundryNodes(node.left);
                Console.Write(node.data + " ");
                
            }
        }
    }
}

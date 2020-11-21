using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGraph
{
    public class SerializeandDeserializeBinaryTree
    {
        public static List<Node> listOfTreeNodes = new List<Node>();
        public static List<Node> SerializeBinaryTree(Node root)
        {
            if (root == null)
            {
                listOfTreeNodes.Add(new Node(-1));
               // return listOfTreeNodes;
            }
            else
            {
                listOfTreeNodes.Add(root);
                SerializeBinaryTree(root.left);
                SerializeBinaryTree(root.right);
            }
           
            return listOfTreeNodes;
        }

        public static Node DeserializeBinaryTree(List<Node> listofNodes)
        {
            if (listofNodes.Count <= 0)
            {
                return null;
            }

            var root = listofNodes[0];
            DeserializeBinaryTreeRecursion(listofNodes, root);

            return root;
        }

        private static int start = 0;
        private static void DeserializeBinaryTreeRecursion(List<Node> listofNodes, Node root)
        {
            if (listofNodes[start].data == -1)
            {
                return;
            }
            start++;

            DeserializeBinaryTreeRecursion(listofNodes, root.left);
            DeserializeBinaryTreeRecursion(listofNodes, root.right);
        }
    }
}

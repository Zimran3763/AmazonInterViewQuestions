using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    class SerializeandDeserializeBinaryTree
    {
        public static List<Tree> listOfTreeNodes = new List<Tree>();
        public static List<Tree> SerializeBinaryTree(Tree root)
        {
            if (root == null)
            {
                listOfTreeNodes.Add(new Tree(-1));
               // return listOfTreeNodes;
            }
            else
            {
                listOfTreeNodes.Add(root);
                SerializeBinaryTree(root.Left);
                SerializeBinaryTree(root.Right);
            }
           
            return listOfTreeNodes;
        }

        public static Tree DeserializeBinaryTree(List<Tree> listofNodes)
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
        private static void DeserializeBinaryTreeRecursion(List<Tree> listofNodes, Tree root)
        {
            if (listofNodes[start].Value == -1)
            {
                return;
            }
            start++;

            DeserializeBinaryTreeRecursion(listofNodes, root.Left);
            DeserializeBinaryTreeRecursion(listofNodes, root.Right);
        }
    }
}

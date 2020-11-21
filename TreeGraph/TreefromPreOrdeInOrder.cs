using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TreeGraph
{
 
    public class TreefromPreOrdeInOrder
    {
        public static int preIndex = 0;
        public static Node buildTree(int[] preOrder, int[] inOrder, int startIndex, int endIndex)
        {
             
            if (startIndex > endIndex)
                return null;
            var rootNode = new Node(preOrder[preIndex++]);

            if (startIndex == endIndex)
                return rootNode; 

            int indexOfNode = searchOfIndexNode(inOrder, endIndex, startIndex, rootNode.data);

            rootNode.left = buildTree(preOrder, inOrder, startIndex, indexOfNode - 1);
            rootNode.right = buildTree(preOrder,inOrder, indexOfNode+1,endIndex);

            return rootNode;
        }

        private static int searchOfIndexNode(int[] arr, int endIndex, int startIndex,int val)
        {
            int i;
            for (i = startIndex; i <= endIndex; i++)
            {
                if (arr[i] == val)
                    return i;
            }
            return i;
        }
    }
}

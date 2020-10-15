using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewCakeConsoleApp;

namespace Amazon
{
    public class Tree
    {
        public int Value { get; }
        public Tree Right { get; set; }
        public Tree Left { get; set; }
        public Tree( int value)
        {
            Value = value;
            Right = Left = null;
        }
    }
    public class TreefromPreOrdeInOrder
    {
        public static int preIndex = 0;
        public static Tree buildTree(int[] preOrder, int[] inOrder, int startIndex, int endIndex)
        {
             
            if (startIndex > endIndex)
                return null;
            var rootNode = new Tree(preOrder[preIndex++]);

            if (startIndex == endIndex)
                return rootNode; 

            int indexOfNode = searchOfIndexNode(inOrder, endIndex, startIndex, rootNode.Value);

            rootNode.Left = buildTree(preOrder, inOrder, startIndex, indexOfNode - 1);
            rootNode.Right = buildTree(preOrder,inOrder, indexOfNode+1,endIndex);

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

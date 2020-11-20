using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class ConvertBinaryTreeInToBST
    {
        public class ConvertBTtoBST<T>
        {
            //Represent the root of binary tree  
            public Node root;

            int[] treeArray;
            int index = 0;

            public ConvertBTtoBST()
            {
                root = null;
            }

            //convertBTBST() will convert a binary tree to binary search tree  
            public Node convertBTBST(Node node)
            {

                //Variable treeSize will hold size of tree  
                int treeSize = calculateSize(node);
                treeArray = new int[treeSize];

                //Converts binary tree to array  
                convertBTtoArray(node);

                //Sort treeArray  
                Array.Sort(treeArray);

                //Converts array to binary search tree  
                Node d = createBST(0, treeArray.Length - 1);
                return d;
            }

            //calculateSize() will calculate size of tree  
            int calculateSize(Node node)
            {
                int size = 0;
                if (node == null)
                    return 0;
                else
                {
                    size = calculateSize(node.left) + calculateSize(node.right) + 1;
                    return size;
                }
            }

            //convertBTtoArray() will convert the given binary tree to its corresponding array representation  
            public void convertBTtoArray(Node node)
            {
                //Check whether tree is empty  
                if (root == null)
                {
                    Console.WriteLine("Tree is empty");
                    return;
                }
                else
                {
                    if (node.left != null)
                        convertBTtoArray(node.left);
                    //Adds nodes of binary tree to treeArray  
                    treeArray[index] = node.data;
                    index++;
                    if (node.right != null)
                        convertBTtoArray(node.right);
                }
            }

            //createBST() will convert array to binary search tree  
            public Node createBST(int start, int end)
            {

                //It will avoid overflow  
                if (start > end)
                {
                    return null;
                }

                //Variable will store middle element of array and make it root of binary search tree  
                int mid = (start + end) / 2;
                Node node = new Node(treeArray[mid]);

                //Construct left subtree  
                node.left = createBST(start, mid - 1);

                //Construct right subtree  
                node.right = createBST(mid + 1, end);

                return node;
            }

            //inorder() will perform inorder traversal on binary search tree  
            public void inorderTraversal(Node node)
            {

                //Check whether tree is empty  
                if (root == null)
                {
                    Console.WriteLine("Tree is empty");
                    return;
                }
                else
                {

                    if (node.left != null)
                        inorderTraversal(node.left);
                    Console.Write(node.data + " ");
                    if (node.right != null)
                        inorderTraversal(node.right);

                }
            }
        }
    }
}

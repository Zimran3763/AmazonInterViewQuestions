using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class InOrderTraversal
    {
        public static void RecursiveInOrder(Node tree)
        {
            if (tree == null)
                return;
            RecursiveInOrder(tree.left);
            Console.WriteLine(tree.data);
            RecursiveInOrder(tree.right);
        }
        public static void IterativeInOrder(Node tree)
        {
            Node curr = tree;
            Stack<Node> ts = new Stack<Node>();
            while (curr != null || ts.Count != 0)
            {
                if (curr != null)
                {
                    ts.Push(curr);
                    curr = curr.left;

                }
                else
                {
                    curr = ts.Pop();
                    Console.WriteLine(curr.data);
                    curr = curr.right;
                }
            }

        }

        public static void RecursivePreOrder(Node tree)
        {
            if (tree == null)
                return;
            Console.Write(tree.data + "");
            RecursivePreOrder(tree.left);
            RecursivePreOrder(tree.right);
        }

        public static void IterativePreOrder(Node tree)
        {
            if (tree == null)
                return;

            Stack<Node> nodes = new Stack<Node>();
            Node node = tree;
            nodes.Push(node);
            while (nodes.Count != 0)
            {
                node = nodes.Pop();
                Console.Write(node.data + "");
                if (node.right != null)
                {
                    nodes.Push(node.right);
                }
                if (node.left != null)
                {
                    nodes.Push(node.left);
                }
            }
        }
        public static void RecursivePostOrder(Node tree)
        {
            if (tree == null)
                return;

            RecursivePreOrder(tree.left);
            RecursivePreOrder(tree.right);
            Console.Write(tree.data + "");
        }

        public static void IterativePostOrder(Node root)
        {
            // create an empty stack and push root node
            Stack<Node> stk = new Stack<Node>();
            stk.Push(root);

            // create another stack to store post-order traversal
            Stack<int> outStack = new Stack<int>();

            // loop till stack is empty
            while (stk.Count!=0)
            {
                // we pop a node from the stack and push the data to output stack
                Node curr = stk.Peek();
                stk.Pop();

                outStack.Push(curr.data);

                // push left and right child of popped node to the stack
                if (curr.left!=null)
                    stk.Push(curr.left);

                if (curr.right!=null)
                    stk.Push(curr.right);
            }

            // print post-order traversal
            while (outStack.Count!=0)
            {
                Console.Write(outStack.Peek()+"");
                outStack.Pop();
            }
        }

    }
}

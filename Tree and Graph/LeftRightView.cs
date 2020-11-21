using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class LeftRightView
    {
        public static void LeftViewIterative(Node tree)
        {
            if (tree == null) return;
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(tree);
            q.Enqueue(null);
            
            while(q.Count>0)
            {
                Node temp = q.Peek();

                if(temp!=null)
                {
                    Console.Write(""+temp.data+"");

                    while (temp!=null)
                    {
                        if (temp.left != null)
                            q.Enqueue(temp.left);
                        if (temp.right != null)
                            q.Enqueue(temp.right);
                        q.Dequeue();
                        temp = q.Peek();
                    }
                    q.Enqueue(null);
                }
                q.Dequeue();
            }
        }
        public static void LeftViewRecursive(Node tree, int level, int maxLevel)
        {
            if (tree == null) return;
            if(maxLevel<level)
            {
                Console.WriteLine(tree.data);
                maxLevel = level;
            }

            LeftViewRecursive(tree.left, level + 1, maxLevel);
            LeftViewRecursive(tree.right, level + 1, maxLevel);

        }

        public static void rightViewUtil(Node node, int level,
                                        int max_level)
        {

            // Base Case  
            if (node == null)
            {
                return;
            }

            // If this is the last Node of its level  
            if (max_level < level)
            {
                Console.Write(node.data + " ");
                max_level = level;
            }

            // Recur for right subtree first, then left subtree  
            rightViewUtil(node.right, level + 1, max_level);
            rightViewUtil(node.left, level + 1, max_level);
        }

        private static void printRightView(Node root)
        {
            if (root == null)
                return;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                // number of nodes at current level  
                int n = queue.Count;

                // Traverse all nodes of current level  
                for (int i = 1; i <= n; i++)
                {
                    Node temp = queue.Dequeue();

                    // Print the right most element at  
                    // the level  
                    if (i == n)
                        Console.Write(temp.data + " ");

                    // Add left node to queue  
                    if (temp.left != null)
                        queue.Enqueue(temp.left);

                    // Add right node to queue  
                    if (temp.right != null)
                        queue.Enqueue(temp.right);
                }
            }
        }
    }
}

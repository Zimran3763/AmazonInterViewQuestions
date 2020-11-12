using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class ZigZag
    {
        public static void ZigZagTraversal(Node rootNode)
        {
            if (rootNode == null)
            {
                return;
            }

            // declare two stacks  
            Stack<Node> currentLevel = new Stack<Node>();
            Stack<Node> nextLevel = new Stack<Node>();

            // push the root  
            currentLevel.Push(rootNode);
            bool leftToRight = true;

            // check if stack is empty  
            while (currentLevel.Count > 0)
            {

                // pop out of stack  
                Node node = currentLevel.Pop();

                // print the data in it  
                Console.Write(node.data + " ");

                // store data according to current  
                // order.  
                if (leftToRight)
                {
                    if (node.left != null)
                    {
                        nextLevel.Push(node.left);
                    }

                    if (node.right != null)
                    {
                        nextLevel.Push(node.right);
                    }
                }
                else
                {
                    if (node.right != null)
                    {
                        nextLevel.Push(node.right);
                    }

                    if (node.left != null)
                    {
                        nextLevel.Push(node.left);
                    }
                }

                if (currentLevel.Count == 0)
                {
                    leftToRight = !leftToRight;
                    Stack<Node> temp = currentLevel;
                    currentLevel = nextLevel;
                    nextLevel = temp;
                }
            }
        }
    }
}

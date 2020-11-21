using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestions
{
    public class TopAndBottomView
    {
        public class Pair
        {
            public int hd;
            public Node firstData;
            public Pair(Node node, int d)
            {
                firstData = node;
                hd = d;
            }
        }
        public static void TopView(Node root)
        {
            // Base case
            if (root == null)
            {
                return;
            }

            // Take a temporary node
            Node temp = null;

            // Queue to do BFS
            Queue<Node> q = new Queue<Node>();

            // map to store node at each vartical distance
            Dictionary<int, int> mp = new Dictionary<int, int>();
            int hd = 0;
            root.hd = hd;
            q.Enqueue(root);


            // BFS
            while (q.Count > 0)
            {

                temp = q.Dequeue();
                hd = temp.hd;
                 
                // If any node is not at that vertical distance
                // just insert that node in map and print it
                if (!mp.ContainsKey(temp.hd))
                {
                    Console.Write(temp.data + " ");
                    mp.Add(hd, temp.data);
                }

                // Continue for left node
                if (temp.left != null)
                {
                    temp.left.hd = hd - 1;
                    q.Enqueue(temp.left);
                }

                // Continue for right node
                if (temp.right != null)
                {
                    temp.right.hd = hd + 1;
                    q.Enqueue(temp.right);
                }
            }
        }

        public static void BottomView(Node root)
        { 
            if (root == null)
                return;

            // TreeMap which stores key value pair sorted on key value 
            Dictionary<int, int> map = new Dictionary<int, int>();

            // Queue to store tree nodes in level order traversal 
            Queue<Node> queue = new Queue<Node>();

            // Initialize a variable 'hd' with 0 for the root element. 
            int hd = 0;
            // Assign initialized horizontal distance value to root 
            // node and add it to the queue. 
            root.hd = hd;
            queue.Enqueue(root);
            

            // Loop until the queue is empty (standard level order loop) 
            while (queue.Count>0)
            {
                Node temp = queue.Dequeue();
                // Extract the horizontal distance value from the 
                // dequeued tree node. 
                hd = temp.hd;

                // Put the dequeued tree node to TreeMap having key 
                // as horizontal distance. Every time we find a node 
                // having same horizontal distance we need to replace 
                // the data in the map. 
                //if(!map.ContainsKey(dis))
                   map[hd] = temp.data;

                // If the dequeued node has a left child add it to the 
                // queue with a horizontal distance hd-1. 
                if (temp.left != null)
                {
                    temp.left.hd = hd - 1;
                    queue.Enqueue(temp.left);
                }

                // If the dequeued node has a left child add it to the 
                // queue with a horizontal distance hd+1. 
                if (temp.right != null)
                {
                    temp.right.hd = hd + 1;
                    queue.Enqueue(temp.right);
                }
            }

            foreach(var val in map.OrderBy(i=>i.Key))
            {
                Console.Write(val.Value + "");
            }
        }
    }
}


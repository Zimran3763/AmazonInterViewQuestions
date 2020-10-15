using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewCakeConsoleApp;

namespace Amazon
{
    public class AmazonClass
    {
        public static void Main(string[] args)
        {
            #region Tree from PreOrder and InOrder
            int[] preOrder = new int[] { 1,2,4,5,3};
            int[] inOrder = new int[] { 4,2,5,1,3};
            int endIndex = preOrder.Length -1;
            int startIndex = 0;
            TreefromPreOrdeInOrder.buildTree(preOrder, inOrder, startIndex, endIndex );
            #endregion

            #region Max Path Sum Binary Tree
            Tree node = new Tree(10);
            node.Left = new Tree(2);
            node.Left.Left = new Tree(20);
            node.Left.Right = new Tree(1);
            node.Right = new Tree(10);
            node.Right.Right = new Tree(-25);
            node.Right.Right.Left = new Tree(3);
            node.Right.Right.Right = new Tree(4);
            MaximumPathSumBinaryTree.maxPath(node);
            #endregion

            #region Serialize and Deserialaze Tree 
            // var serializationTree = new SerializeandDeserializeBinaryTree();
            List<Tree> tree = SerializeandDeserializeBinaryTree.SerializeBinaryTree(node);
            SerializeandDeserializeBinaryTree.DeserializeBinaryTree(tree);
            #endregion

            #region Graph is Tree
            Graph g1 = new Graph(5); 
            g1.addEdge(1, 0); 
            g1.addEdge(0, 2); 
            g1.addEdge(0, 3); 
            g1.addEdge(3, 4); 
            if (g1.isTree()) 
                Console.WriteLine("Graph is Tree"); 
            else
                Console.WriteLine("Graph is not Tree"); 
  
            Graph g2 = new Graph(5); 
            g2.addEdge(1, 0); 
            g2.addEdge(0, 2); 
            g2.addEdge(2, 1); 
            g2.addEdge(0, 3); 
            g2.addEdge(3, 4); 
  
            if (g2.isTree()) 
                Console.WriteLine("Graph is Tree"); 
            else
                Console.WriteLine("Graph is not Tree");
            #endregion

            #region given Itenrary
            
            Hashtable dataSet = new Hashtable();
            dataSet.Add("Chennai", "Banglore");
            dataSet.Add("Bombay", "Delhi");
            dataSet.Add("Goa", "Chennai");
            dataSet.Add("Delhi", "Goa");

            PrintItinerary.printResult(dataSet);
            #endregion
        }

    }
}

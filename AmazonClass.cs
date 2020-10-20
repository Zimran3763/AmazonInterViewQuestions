using Amazon;
using ArraysStrings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class AmazonClass
    {
        public static void Main(string[] args)
        {
            #region Tree from PreOrder and InOrder
            int[] preOrder = new int[] { 1, 2, 4, 5, 3 };
            int[] inOrder = new int[] { 4, 2, 5, 1, 3 };
            int endIndex = preOrder.Length - 1;
            int startIndex = 0;
            TreefromPreOrdeInOrder.buildTree(preOrder, inOrder, startIndex, endIndex);
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

            #region PrerequisitCourses
            int numCourses = 4;
            int[][] prerequisites = new int[][]
            {
                new int[]{ 1, 0 },
                new int[]{ 1, 0 },
                new int[]{ 2, 0 },
                new int[]{ 3, 1 },
                new int[]{ 3, 2 }
            };
            CourseTaken.FindOrder(numCourses, prerequisites);
            #endregion

            #region Two Sum 
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            var resultArray = TwoSum.TwoSumIndex(nums, target);
            #endregion

            #region Three Sum 
            int[] numsArray = { -1, 0, 1, 2, -1, -4 };
            
            var resArray = ThreeSum.ThreeSumArray(numsArray);
            #endregion

            #region Longest Palindrom
            string s = "iababrabcbazmabccbaxyz";
            LongestPalindrom.longestPalindromicSubstring(s);
            #endregion

            #region Most Common Word
            //string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string paragraph = "a.";
            string [] banned = { "a"};

            MostCommonWord.mostCommonWordSubstring(paragraph, banned);
            #endregion

            #region Integer equivalent string
            int numArray = 9;
            IntegerToItsEnglishWord.numberToWords(numArray);
            #endregion

            #region Search Suggestions System
            string[] products = { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            string searchWord = "mouse";
            SearchSuggestionsSystem.SuggestedProducts(products, searchWord);
            #endregion
        }

    }
}

using Amazon;
using ArraysStrings;
using SearchSort;
using LinkedLists;
using HashTable;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackQueues;
using AmazonQuestions;

namespace Amazon
{
    public class AmazonClass
    {
        public static void Main(string[] args)
        {
            #region Diameter of a tree
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            int diameter = int.MinValue;
            DiameterOfTree.height(root,diameter);
            MirrorOFATree.Mirrorify(root);
            InOrderTraversal.RecursiveInOrder(root);
            InOrderTraversal.IterativeInOrder(root);
            InOrderTraversal.IterativePostOrder(root);

            #endregion

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

            #region Most Common Word
            //string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string comments = "I wish my Kindle had even more storage\",\"I wish the battery life on my Kindle lasted 2 years\", \"I read in the bath and would enjoy a waterproof Kindle\",\"I want to take my Kindle into the hover. Waterproof please waterproof!\", \"It would be neat if my Kindle would hover on my desk when not in use\",\"How cool would it be if my Kindle charged in the sun via solar power?";
            string[] possibleFeatures = { "storage", "battery", "hover", "alexa", "waterproof", "solar" };

            PossibleFeatures.possibleFeaturesInComment(comments, possibleFeatures);
            #endregion

            #region Reverse Nodes in k-Group
            var a = new SinglyLinkedList(1);
            a.Next = new SinglyLinkedList(2);
            a.Next.Next = new SinglyLinkedList(3);
            a.Next.Next.Next = new SinglyLinkedList(4);
            a.Next.Next.Next.Next = new SinglyLinkedList(5);
            a.Next.Next.Next.Next.Next = new SinglyLinkedList(6);
            a.Next.Next.Next.Next.Next.Next = new SinglyLinkedList(7);
            a.Next.Next.Next.Next.Next.Next.Next = new SinglyLinkedList(8);
            int k = 3;
            ReverseNodesInKGroup.ReverseKGroup(a,k);
            #endregion

            #region merge two lists
            var l1 = new SinglyLinkedList(1);
            l1.Next = new SinglyLinkedList(2);
            l1.Next.Next = new SinglyLinkedList(4);

            var l2 = new SinglyLinkedList(1);
            l2.Next = new SinglyLinkedList(3);
            l2.Next.Next = new SinglyLinkedList(4);
            MergeTwoSortedLists.MergeList(l1, l2);
            #endregion

            #region merge k linked lists
            SinglyLinkedList[] arr = new SinglyLinkedList[k];

            arr[0] = new SinglyLinkedList(1);
            arr[0].Next = new SinglyLinkedList(3);
            arr[0].Next.Next = new SinglyLinkedList(5);
            arr[0].Next.Next.Next = new SinglyLinkedList(7);

            arr[1] = new SinglyLinkedList(2);
            arr[1].Next = new SinglyLinkedList(4);
            arr[1].Next.Next = new SinglyLinkedList(6);
            arr[1].Next.Next.Next = new SinglyLinkedList(8);

            arr[2] = new SinglyLinkedList(0);
            arr[2].Next = new SinglyLinkedList(9);
            arr[2].Next.Next = new SinglyLinkedList(10);
            arr[2].Next.Next.Next = new SinglyLinkedList(11);

            MergeKSortedLists.MergeKLists(arr);
            #endregion

            #region Clone linked list with random pointer
            var listWithRandom = new SinglyLinkedList(1);
            listWithRandom.Next = new SinglyLinkedList(2);
            listWithRandom.Next.Next = new SinglyLinkedList(3);
            listWithRandom.Next.Next.Next = new SinglyLinkedList(4);
            listWithRandom.Next.Next.Next.Next = new SinglyLinkedList(5);

            // Setting up random references. 
            listWithRandom.RandomPointer = listWithRandom.Next.Next;
            listWithRandom.Next.RandomPointer = listWithRandom.Next.Next.Next;
            listWithRandom.Next.Next.RandomPointer = listWithRandom.Next.Next.Next.Next;
            listWithRandom.Next.Next.Next.RandomPointer = listWithRandom.Next.Next.Next.Next.Next;
            listWithRandom.Next.Next.Next.Next.RandomPointer = listWithRandom.Next;
            CopyListWithRandomPointer.CopyRandomList(listWithRandom);
            #endregion

            #region Sort An Array (Quick Sort)
            int[] arry = { 1,5,4,11,20,8,2,98,90,16};
            int n = arry.Length-1;
            SortAnArrayQuickSort.QuickSort(arry, 0, n );
            Console.WriteLine("sorted array ");
            #endregion

            #region Number Of Island
            char[][] islandArray = new char[][]
            {
                new char[]{ '1', '1', '1', '1', '0' },
                new char[]{ '1', '1', '0', '1', '0' },
                new char[]{ '1', '1', '0', '0', '0' },
                new char[]{ '0', '0', '0', '0', '0' }
            };
            NumberOfIslands.NumIslands(islandArray);
            #endregion

            #region Meeting rooms
            List<Meeting> meetings = new List<Meeting>
            {
             new Meeting(0,4),
             new Meeting(5,10),
             new Meeting(15,20)
            
            };
            MeetingRooms.MergeRanges(meetings);
            #endregion

            #region Search in two d matrix
            int[,] matrix = new int[5,5]
            {
                { 1,  4,  7,  11, 15 },
                { 2,  5,  8,  12, 19 },
                { 3,  6,  9,  16, 22 },
                { 10, 13, 14, 17, 24 },
                { 18, 21, 23, 26, 30 }
            };

            SearchInTwoDMatrix.SearchMatrix(matrix, 17);
            #endregion

            #region Min stack
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            minStack.GetMin(); // return -3
            minStack.Pop();
            minStack.Top();    // return 0
            minStack.GetMin(); // return -2
            #endregion
            
            #region Trap rain water
            int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            TrappingRainWater.Trap(height);
            #endregion

            #region Most Frequent Word
            int frequncy = 2;
            string[] wordArray = new string[]
            {
                "i", "love", "leetcode", "i", "love", "coding"
            };
            KMostFrequentWord.TopKFrequent(wordArray, frequncy);
            #endregion

        }

    }
}

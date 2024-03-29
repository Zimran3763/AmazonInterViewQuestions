﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AmazonOnlineAssessment.PrimeAirRoute;
using static AmazonOnlineAssessment.LargestItemAssociation;

namespace AmazonOnlineAssessment
{
    public class OA
    {     
        public static void Main(string[] args)
        {
            #region air route optimiation
            int maxTravelDist = 7000;
            List<PairInt> forwardRouteList = new List<PairInt>()
            {
                new PairInt(1,2000),
                new PairInt(2,4000),
                new PairInt(3,6000)

            };
            List<PairInt> returnRouteList = new List<PairInt>()
            {
                new PairInt(1,2000)
            };
            getOptimizedUtilize(maxTravelDist, forwardRouteList, returnRouteList);
            #endregion

            #region Amazon fresh promotion
            string[][] codeList = new string[][]
            {
                new string[] { "apple", "apple" },
                new string [] {"banana", "anything", "banana" }

            };

            string[] shoppingCart = new[] { "apple", "orange", "apple", "banana", "orange", "banana" };
            int res = AmazonFreshPromotion.isWinner(codeList, shoppingCart);
            #endregion

            #region Item In Conainer
            string s1 = "|**|*|*";
            int[] startIndices = new int[] { 1, 1 };
            int[] endIndices = new int[] { 5, 6 };
            ItemInContainer.NumberOfItems(s1, startIndices, endIndices);
            #endregion

            #region Largest Item association
            List<PairString> itemAssociation1 = new List<PairString>()
                        {
                            new PairString("item1", "item2"),
                            new PairString("item3", "item4"),
                            new PairString("item4", "item5")
                        };

            List<PairString> itemAssociation2 = new List<PairString>()
                        {
                            new PairString("item1", "item2"),
                            new PairString("item4", "item5"),
                            new PairString("item3", "item4"),
                            new PairString("item1", "item4")
                        };

            var ans1 = LargestItemAssociationFunction(itemAssociation1);
            #endregion

            #region turnstile
            int[] time = new int[] { 1, 1, 3, 3, 4, 5, 6, 7, 7 };
            int[] direction = new int[] { 1, 1, 0, 0, 0, 1, 1, 1, 1 };
            //[1,2,3,4,5,6,7,8,9]

            var ans = Turnstile.gate(time, direction);
            #endregion

            #region five star sellers
            int[][] rating = new int[][]
            { new int[]{ 4, 4} ,
              new int[]{1, 2 },
              new int[]{3, 6}
            };
            var ans2 = FiveStarSellers.fiveStar(rating, 77);
            #endregion

            #region AutoScalePolicy
            List<int> averageUtil = new List<int>();
            averageUtil.Add(1);
            averageUtil.Add(2);
            averageUtil.Add(3);
            averageUtil.Add(4);
            averageUtil.Add(5);
            averageUtil.Add(10);
            averageUtil.Add(80);
            AutoScalePolicy.finalInstance(1, averageUtil);
            #endregion

            #region Top K frequent word
            int k = 2;
            string[] keywords = { "anacell", "cetracular", "betacellular" };
            string[] reviews = {
                                  "Anacell provides the best services in the city",
                                  "betacellular has awesome services",
                                  "Best services provided by anacell, everyone should use anacell",
            };
            TopKFrequentWord.getMostFrequentCommonwords(reviews, keywords, k);

            int numFeatures = 6;
            int topFeatures = 2;
            string [] possibleFeatures =  new []{ "storage","battery","hover","alexa","waterproof","solar"};
            int numFeatureRequests = 7;
            string [] featureRequests = new []{"I wish my Kindle had even more storage!","I wish the battery life on my Kindle lasted 2 years.","Tread in the bath andwould enjoy a waterproof Kindle","Waterproof and increased battery aremy top two requests.", "I want to take my Kindle into the shower.Waterproof please waterproof !", "It would be neat if my Kindle wouldhover on my desk when not in use.","How cool would it be if my Kindle charged in the sun via solar power?"};
            TopKFrequentWord.popularNFeatures( numFeatures,  topFeatures, possibleFeatures,  numFeatureRequests,  featureRequests);
            #endregion

            #region Gifting Groups and Friend circle
            int[][] friendCircle = new int[][]
            {
                new int []{1,1,0 },
                new int []{1,1,0 },
                new int []{0,0,1 }
            };
            GIftingGroupFriendCircle.FindCircleNum(friendCircle);
            #endregion

            #region K closest point to origin
            //int[][] points = new int[][]
            //{
            //    new int []{3,3 },
            //    new int []{-2,4 },
            //    new int []{5,-1 }
            //};
            int[][] points1 = new int[][]
            {
                new int []{1,3 },
                new int []{-2,2 }
            };
            KClosestPointToOrigin.KClosest(points1, 1);
            #endregion

            #region Distance between nodes in BST
            var arr = new int[] { 4, 2, 7, 1, 3, 5 };
            var node1 = 1;
            var node2 = 3;

            //Create BST by using given array
            DistanceBetweenNodesInBST.buildBST(arr,node1,node2);

            //Distance between two given node
            var commonAncestor = DistanceBetweenNodesInBST.bstDistance(arr, node1, node2);
            #endregion

            #region Substring of size k 

            string s = "awaglknagawunagwkwagl";
            int k1 = 4;
            SubstringsOfSizeKWithKDistinctChars.LengthOfLongestSubstring(s, k1);

            #endregion

            #region Shopping patterns
            int numOfProducts = 6;
            List<int> products_from = new List<int>()
            {
                1, 2, 2, 3, 4, 5
            };
            List<int> products_to = new List<int>()
            {
                2,4,5,5,5,6
            };

            int min = ShoppingPatterns.getShoppingPatternsTrioMinimum(numOfProducts, products_from, products_to);

            // int trianglesCount = ShoppingPatterns.getTriangleCount(numOfProducts, products_from, products_to);
            #endregion

            #region Beta Testing Minimum difficulty of a job schedule
            int[] jobDifficulty = new int[] { 11, 111, 22, 222, 33, 333, 44, 444 };
            int d = 6;
            BetaTesting_MinimumDifficultyOfAJobTesting.MinDifficulty(jobDifficulty, d);
            #endregion
        }

    }
}

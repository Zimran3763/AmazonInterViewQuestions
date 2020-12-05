using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Amazon is trying to understand customer shopping patterns and offer items that are regularly bought together to new customers. Each item that has been bought together can be represented as an undirected graph where edges join often bundled products. A group of n products is uniquely numbered from 1 of product_nodes. A trio is defined as a group of three related products that all connected by an edge. Trios are scored by counting the number of related products outside of the trio, this is referred as a product sum.

Given product relation data, determine the minimum product sum for all trios of related products in the group. If no such trio exists, return -1.

Example
products_nodes = 6
products_edges = 6
products_from = [1,2,2,3,4,5]
products_to = [2,4,5,5,5,6]*/

namespace AmazonOnlineAssessment
{
    public class ShoppingPatterns
    {
        
        //private static int getTriangleCount(int numOfProducts,
        //List<int> products_from, List<int> products_to)
        //{
        //    Dictionary<int, HashSet<int>> graph = new Dictionary<int, HashSet<int>>();
        //    for (int i = 1; i <= numOfProducts; i++)
        //    {
        //        graph.Add(i, (new HashSet<int>()));
        //    }

        //    for (int i = 0; i < products_from.Count(); i++)
        //    {
        //        //since its undirected
        //        graph[products_from[i]].Add(products_to[i]);
        //        graph[products_to[i]].Add(products_from[i]);
        //    }

        //    int countTriangles = int.MaxValue;
        //    for (int i = 1; i <= numOfProducts; i++)
        //    {
        //        for (int j = i + 1; j <= numOfProducts; j++)
        //        {
        //            for (int k = j + 1; k <= numOfProducts; k++)
        //            {
        //                if (graph[i].Contains(j) && graph[j].Contains(k) && graph[k].Contains(i))
        //                {
        //                    countTriangles++;
        //                }
        //            }
        //        }
        //    }
        //    countTriangles /= 6;
        //    return countTriangles;
        //}
        
        public static int getShoppingPatternsTrioMinimum(int numOfProducts,
            List<int> products_from, List<int> products_to)
        {
            if (numOfProducts < 1 || products_from == null || products_to == null || products_to.Count() != products_from.Count()) return -1;

            Dictionary<int, HashSet<int>> graph = new Dictionary<int, HashSet<int>>();
            for (int i = 1; i <= numOfProducts; i++)
            {
                graph.Add(i, (new HashSet<int>()));
            }

            for (int i = 0; i < products_from.Count(); i++)
            {
                //since its undirected
                graph[products_from[i]].Add(products_to[i]);
                graph[products_to[i]].Add(products_from[i]);
            }

            int count = int.MaxValue;
            for (int i = 1; i <= numOfProducts; i++)
            {
                for (int j = i + 1; j <= numOfProducts; j++)
                {
                    for (int k = j + 1; k <= numOfProducts; k++)
                    {
                        if (graph[i].Contains(j) && graph[j].Contains(k) && graph[k].Contains(i))
                        {
                            // these vertices forms a TRio
                            int val = (graph[i].Count() + graph[j].Count() + graph[k].Count()) - 6;
                            count = Math.Min(count, val);
                        }
                    }
                }
            }
            return count;
        }
    }
}

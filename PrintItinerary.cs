using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    /*
     332. Reconstruct Itinerary
    Given a list of airline tickets represented by pairs of departure and arrival airports [from, to], reconstruct the itinerary in order. All of the tickets belong to a man who departs from JFK. Thus, the itinerary must begin with JFK.

    Note:

    If there are multiple valid itineraries, you should return the itinerary that has the smallest lexical order when read as a single string. For example, the itinerary ["JFK", "LGA"] has a smaller lexical order than ["JFK", "LGB"].
    All airports are represented by three capital letters (IATA code).
    You may assume all tickets form at least one valid itinerary.
    One must use all the tickets once and only once.
    Example 1:

    Input: [["MUC", "LHR"], ["JFK", "MUC"], ["SFO", "SJC"], ["LHR", "SFO"]]
    Output: ["JFK", "MUC", "LHR", "SFO", "SJC"]
    Example 2:

    Input: [["JFK","SFO"],["JFK","ATL"],["SFO","ATL"],["ATL","JFK"],["ATL","SFO"]]
    Output: ["JFK","ATL","JFK","SFO","ATL","SFO"]
    Explanation: Another possible reconstruction is ["JFK","SFO","ATL","JFK","ATL","SFO"].
                    But it is larger in lexical order. 
    */

    class PrintItinerary
    {
        public static void printResult(Hashtable dataSet)
        {
            
            // To store reverse of given map 
            Hashtable reverseMap = new Hashtable();
            // To fill reverse map, iterate through the given map 
            foreach (string key in dataSet.Keys)
            {
                reverseMap.Add(dataSet[key], key);
            }
            //for (Map.Entry<String, String> entry: dataSet.entrySet())
            //    reverseMap.put(entry.getValue(), entry.getKey());

            //// Find the starting point of itinerary 
            string start = null;
            foreach (string key in dataSet.Keys)
            {
                if (!reverseMap.ContainsKey(key))
                {
                    start = key;
                    break;
                }
            }

            //// If we could not find a starting point, then something wrong 
            //// with input 
            if (start == null)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            //// Once we have starting point, we simple need to go next, next 
            //// of next using given hash map 
            string to = (string)dataSet[start];
            while (to != null)
            {
                Console.Write(start + "->" + to + ", ");
                start = to;
                to = (string)dataSet[to];
            }
        }
    }
}

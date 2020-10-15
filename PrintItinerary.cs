using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
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

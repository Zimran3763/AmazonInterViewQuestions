using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnlineAssessment
{
    public class LargestItemAssociation
    {
        public static List<String> LargestItemAssociationFunction(List<PairString> itemAssociation)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            //fill dictionary with key and pair with list if key has more than one pair
            foreach (var pair in itemAssociation)
            {
                if (!map.ContainsKey(pair.first))
                {
                    map.Add(pair.first, new List<string>());
                }
                if (!map.ContainsKey(pair.second))
                {
                    map.Add(pair.second, new List<string>());
                }
                map[pair.first].Add(pair.second);
                map[pair.second].Add(pair.first);
            }
            //Create a visited hashset 
            //and a resulset list where we stored our results
            HashSet<string> visited = new HashSet<string>();
            List<List<string>> lists = new List<List<string>>();
            int max = int.MinValue;

            foreach (var key in map.Keys.OrderBy(x => x))
            {
                //create list to add returned list from the function
                List<String> li = new List<String>();
                Dfs(key, map, visited, li);

                if (max < li.Count)
                {
                    max = li.Count;
                    li.Sort();
                    lists.Add(li);
                }
            }
            //return the max count list fro the resultant list
            return lists.FirstOrDefault(x => x.Count == max);
        }

        //process all the nodes and it's adjacent nodes and add them to resultant list and returend it
        private static void Dfs(string node, Dictionary<string, List<string>> map, HashSet<string> visited, List<String> li)
        {
            if (visited.Contains(node))
                return;

            visited.Add(node);
            li.Add(node);

            //foreach value from the list of dictionary for the node
            foreach (var nd in map[node])
            {
                Dfs(nd, map, visited, li);
            }
        }
        public class PairString
        {
            public String first;
            public String second;

            public PairString(String first, String second)
            {
                this.first = first;
                this.second = second;
            }
        }
    }
}

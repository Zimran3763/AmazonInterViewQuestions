using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class KMostFrequentWord
    {
        public static IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                    dict.Add(word, 1);
                else
                    dict[word]++;
            }
            return dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).Take(k).ToList();

        }
    }
}

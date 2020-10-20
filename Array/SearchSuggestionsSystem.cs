using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStrings
{
    public class SearchSuggestionsSystem
    {
        public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            Array.Sort(products);

            IList<IList<string>> result = new List<IList<string>>();

            // Copy matches into list, easier to maintain
            var matches = products.ToList();

            for (int i = 0; i < searchWord.Length; i++)
            {
                // For each letter, remove anything that doesn't still match from matches.
                // Each time will be O(matches.Length) first is products.Length and it will get smaller every time.
                filterProducts(i, searchWord[i], matches);

                IList<string> topMatches = new List<string>();
                //run loop if words are  top three in matches 
                for (int j = 0; j < 3 && j < matches.Count; j++)
                {
                    topMatches.Add(matches[j]);
                }

                result.Add(topMatches);
            }

            return result;
        }

        private static void filterProducts(int index, char c, List<string> products)
        {
            // Iterate backwards to remove
            for (int i = products.Count - 1; i >= 0; i--)
            {
                //check if product list is less than the search word or product list has that search word in that spot
                if (products[i].Length < (index + 1) || products[i][index] != c)
                {
                    products.RemoveAt(i);
                }
            }
        }
    }
    
}

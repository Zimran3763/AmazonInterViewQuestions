using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnlineAssessment
{
    public class MostCommonWord
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            string result = string.Empty;
            //replace all the symbols
            paragraph = paragraph.Replace("!", " ")
                                  .Replace("?", " ")
                                  .Replace("'", " ")
                                  .Replace(",", " ")
                                  .Replace(";", " ")
                                  .Replace(".", " ")
                                  .Trim();

            //Hashtable to store all banned item so we can ignore it while adding word into               //dictionary
            HashSet<string> bannedTable = new HashSet<string>();

            //To store all the word from the string  except banned        
            Dictionary<string, int> countSubstring = new Dictionary<string, int>();

            //Add all the word from banned array to hashtable
            foreach (var item in banned)
                bannedTable.Add(item.ToLower());

            foreach (var item in paragraph.Split(' '))
            {


                if (item != string.Empty && !bannedTable.Contains(item.ToLower()))
                {
                    if (!countSubstring.ContainsKey(item.ToLower()))
                        countSubstring.Add(item.ToLower(), 1);

                    countSubstring[item.ToLower()] += 1;
                }

            }

            // maximum value key would be our answer
            foreach (var item in countSubstring.Keys)
            {

                if (countSubstring[item] == countSubstring.Values.Max())
                {
                    result = item;

                }
            }
            return result;
        }
    }
}

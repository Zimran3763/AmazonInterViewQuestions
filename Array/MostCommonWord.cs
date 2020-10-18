using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStrings
{
    public class MostCommonWord
    {
        public static string mostCommonWordSubstring(string s, string[] banned)
        {
            
            string result = string.Empty;
            s = s.Replace("!", " ")
                                  .Replace("?", " ")
                                  .Replace("'", " ")
                                  .Replace(",", " ")
                                  .Replace(";", " ")
                                  .Replace(".", " ")
                                  .Trim();
            //Hashtable to store all banned item
            HashSet<string> bannedTable = new HashSet<string>();
            //To store all the word from the string          
            Dictionary<string,int> countSubstring = new Dictionary<string, int>();

            //Add all the word from banned array to hashtable
            foreach (var item in banned)
                bannedTable.Add(item.ToLower());           

            foreach (var item in s.Split(' '))
            {
               
                
                    if (item != string.Empty && !bannedTable.Contains(item.ToLower()))
                    {
                        if (!countSubstring.ContainsKey(item.ToLower()))
                            countSubstring.Add(item.ToLower(),  1);

                        countSubstring[item.ToLower()] += 1;
                    }
                    
            }
            
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

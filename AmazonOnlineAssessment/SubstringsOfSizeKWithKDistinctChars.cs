using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnlineAssessment
{
    public class SubstringsOfSizeKWithKDistinctChars
    {
        public static List<string> LengthOfLongestSubstring(string s,int k)
        {
            //create hashset to put unique char
            //create result hashset to put 
            HashSet<char> window = new HashSet<char>();
            HashSet<String> result = new HashSet<string>();
            for (int start = 0, end = 0; end < s.Length; end++)
            {
                //if char is already in window hashset than remove it or slide a window i++
                
                for (; window.Contains(s[end]); start++)
                {
                    window.Remove(s[start++]);
                }

                //but also add the existing end index char
                window.Add(s[end]);

                if (window.Count == k)
                {
                    //add string from start index to 4 char
                    result.Add(s.Substring(start, k));
                    //slide a window by start++
                    window.Remove(s[start++]);
                }
            }
            return new List<string>(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Given a string s, return the longest palindromic substring in s.

Example 1:

Input: s = "babad"
Output: "bab"
Note: "aba" is also a valid answer.
 */

namespace AmazonTop50QuestionsFromLeetCode
{
    public class LongestPalindromicSubstring
    {
        public String longestPalindrome(String s)
        {
            //if null or empty return nothing
            if (s == null || s.Length < 1) return "";
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                //check each word case like "racecar" where we have odd number palindrome
                int len1 = expandAroundCenter(s, i, i);
                //check if palindrome is even
                int len2 = expandAroundCenter(s, i, i + 1);
                //chcek which palindrome is bigger
                int len = Math.Max(len1, len2);
                //set new start and end index if len is greater than difference of start and end
                if (len > end - start)
                {
                    //start would be current index and minus half 
                    start = i - (len - 1) / 2;
                    //end would be current index and plus half length
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end + 1);
        }

        private int expandAroundCenter(String s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }
    }
}

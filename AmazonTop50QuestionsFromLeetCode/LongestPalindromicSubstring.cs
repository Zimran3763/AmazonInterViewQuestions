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
                    /*lets still try with this formula start = i - len/2
                    start = 2 - (4/2)   // i =2, len = 4 ( abba)
                    start = 2 -2 =0 ( wrong!)
                    end = i + (len/2)
                    end = 2 + 2 = 4
                    s.substring( 0, 4+1)   // ''eabba'  --> wrong solution!!!
                    Here start should have been 1
                    lets recalculate start as-
                    start = i - (len-1)/2
                    start = 2 - (4-1)/2
                    start = 2- 3/2
                    start = 2 -1 = 1
                    s.substring(1, 4+1)  // 'abba'  --> correct solution

                    So you should calculate start as start = i - (len-1)/2 to take care of the case when palindrome is of 'even' length. For palindrome being 'odd' length it would not matter if start is calculated as i - (len/2) or i - (len-1)/2. */
                    start = i - (len - 1) / 2;
                    //end would be current index and plus half length
                    // 1234321 len =7 ; index i = 3; end = 7/2 + 3= index 6
                    end = i + len / 2;
                }
            }
            //we need to add one to get the length because when we substract end -           
            //start we are not countin start index
            //example 0123456 if start index is 1 and end index is 6 then 6-1 = 5
            //length should be 6 instead of 5 so we add 1
            // end -start +1
            return s.Substring(start, end - start + 1);
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

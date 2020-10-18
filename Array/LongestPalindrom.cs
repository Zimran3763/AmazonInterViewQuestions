using System;

namespace ArraysStrings
{
    public class LongestPalindrom
    {
        //babcd
        //imbabrabcbazmabccbaxyz
        public static int longestPalindromicSubstring(string str)
        {
            //    int length = 1;
            //    int startIndex=0;

            //    if (s.Length ==1)
            //    {
            //        return s;
            //    }
            //    bool previous = false;
            //    int left = 0;
            //    int right = s.Length - 1;

            //    while(left<right)
            //    {
            //        if(s[left]==s[right])
            //        {
            //            if(!previous)
            //            {
            //                startIndex = left;
            //                length = right;
            //                previous = true;
            //                left++;
            //                right--;
            //            }
            //        }
            //        else
            //        {
            //            left++;
            //            right--;
            //        }
            //    }
            //    return s.Substring(startIndex, length);
            int maxLength = 1; // The result (length of LPS) 

            int start = 0;
            int len = str.Length;

            int low, high;

            // One by one consider every 
            // character as center point 
            // of even and length palindromes 
            for (int i = 1; i < len; ++i)
            {
                // Find the longest even length 
                // palindrome with center points 
                // as i-1 and i. 
                low = i - 1;
                high = i;
                while (low >= 0 && high < len && str[low] == str[high])
                {
                    if (high - low + 1 > maxLength)
                    {
                        start = low;
                        maxLength = high - low + 1;
                    }
                    --low;
                    ++high;
                }

                // Find the longest odd length 
                // palindrome with center point as i 
                low = i - 1;
                high = i + 1;
                while (low >= 0 && high < len && str[low] == str[high])
                {
                    if (high - low + 1 > maxLength)
                    {
                        start = low;
                        maxLength = high - low + 1;
                    }
                    --low;
                    ++high;
                }
            }

            Console.Write("Longest palindrome substring is: ");
            printSubStr(str, start, start + maxLength - 1);

            return maxLength;
        }
        public static void printSubStr(string str,
                                   int low, int high)
        {
            Console.WriteLine(str.Substring(low,
                                            (high + 1) - low));
        }
    }
}

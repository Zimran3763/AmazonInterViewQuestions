using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnlineAssessment
{
    public class ItemInContainer
    {
        public static int[] NumberOfItems(string s, int[] startIndicies, int[] endIndicies)
        {
            //declare 4 int array 1 for result , 1 for index of wall from left, 1 for index of wall from right, 1 for count of star
            int[] result = new int[startIndicies.Length];
            int[] countOfStar = new int[s.Length];
            int[] leftIdx = new int[s.Length];
            int[] rightIdx = new int[s.Length];
            int sum = 0;
            //enter the index till now 
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                    sum += 1;
                countOfStar[i] = sum;
            }
            //nearest right index of wall
            int seen = -1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '|')
                    seen = i;
                rightIdx[i] = seen;
            }

            //nearest left index of a wall
            seen = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '|')
                    seen = i;
                leftIdx[i] = seen;
            }
            int k = 0;
            while (k < startIndicies.Length)
            {
                int start = startIndicies[k] - 1;

                int end = endIndicies[k] - 1;
                if (rightIdx[start] != -1 && leftIdx[end] != -1)
                {
                    //count of star between left and right indx of wall
                    result[k] = countOfStar[leftIdx[end]] - countOfStar[rightIdx[start]];
                }
                k++;
            }

            return result;
        }
    }
}

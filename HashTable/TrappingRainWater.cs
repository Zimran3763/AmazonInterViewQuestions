using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class TrappingRainWater
    {
        public static int Trap(int[] height)
        {


            int l = height.Length;
            if (l < 3) return 0;
            var leftMax = new int[l];
            var rightMax = new int[l];
            leftMax[0] = height[0];
            rightMax[l - 1] = height[l - 1];

            int result = 0;
            //check all the height in the array and replace it with height seen till that index
            for (int i = 1; i < l; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);

            }
            //same from the right side of array replace max till each index
            for (int j = l - 2; j >= 0; j--)
            {
                rightMax[j] = Math.Max(rightMax[j + 1], height[j]);

            }
            //take min of from right and left of array and substract height of wall on each index and it //to the result
            for (int r = 1; r < l - 1; r++)
            {
                result += Math.Min(leftMax[r], rightMax[r]) - height[r];
            }
            return result;
        }
    }
}
}

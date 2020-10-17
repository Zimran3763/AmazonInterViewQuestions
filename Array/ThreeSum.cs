using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStrings
{
    public class ThreeSum
    {
        public static IList<IList<int>> ThreeSumArray(int[] nums)
        {
            //We declare the list of lists that will contain our result
            IList<IList<int>> resultList = new List<IList<int>>();

            //The edge case
            if (nums.Length < 3)
                return resultList;
            Array.Sort(nums);
            /*Here we declare 3 indexes. This is how it works. 
            -4 -2 -3 -1 0 0 0 2 3 10 21
             s  l                     r 
             
             s - start index, l - left index, r - right index */
            int start = 0, left, right;
            /*The target is that the number we are looking for to be composed out of 2 numbers from our array.
            for example, if we have the startIndex at -4, we are looking for those two numbers in the given array
            which, summed up will be the oposite of -4, which is 4, cuz -4 + 4 = 0 */
            int target;
            /*The start goes from 0 to length-2 becuse look here
             - 4 - 2 - 3 - 1 0 0 0 2 3 10 21
                                     s l  r   */
            while (start < nums.Length - 2)
            {
                //we are multiply with -1 because it will create the opposite number we need
                target = nums[start] *-1;
                left = start + 1;
                right = nums.Length - 1;
                /*Now, the start index is fixed and we move the left and right indexes to find those two number
                which summed up will be the oposite of nums[s]  */
                while (left < right)
                {
                    /*The array is sorted, so if we move to the left the right index, the sum will decrese */
                    if (nums[left] + nums[right] < target)
                    {
                        ++left;
                    }
                    /*Here is the oposite, it the sum of nums[l] and nums[r] is less that what we are looking for,
                    then we move the left index, which means that the sum will increase due to the sorted array.
                    the left index will jump to a bigger value */
                    else if (nums[left] + nums[right] > target)
                    {
                        --right; 
                    }
                    /*If none of those are true, then it means that nums[l]+nums[r] = our desired value */
                    else
                    {
                        /*Here we create the solution and add it to the list of lists which contains the result. */
                        List<int> firstSolutionList = new List<int>() { nums[start], nums[left], nums[right] };
                        resultList.Add(firstSolutionList);
                        /*Now, in order to generate different solutions, we have to jump over
                        repetitive values in the array. if our current left value is equal to list left value we move to next value */
                        while (left < right && nums[left] == firstSolutionList[1])
                            ++left;
                        while (left < right && nums[right] == firstSolutionList[2])
                            --right;
                    }

                }
                /*Now we do the same thing to the start index. */
                int currentStartNumber = nums[start];
                while (start < nums.Length - 2 && nums[start]== currentStartNumber)
                    ++start;

            }
            return resultList;
        }
    }
}

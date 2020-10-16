using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 1. Two Sum
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
     */
namespace ArraysStrings
{
    public class TwoSum
    {
        public static int[] TwoSumIndex(int[] nums, int target)
        {

            var ht = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                int remainingValue = target - nums[i];


                if (ht.Contains(remainingValue))
                    return new int[2] { Convert.ToInt32(ht[remainingValue]), i };
                if (!ht.Contains(nums[i]))
                    ht.Add(nums[i], i);
            }
            return new int[] { };
        }
    }
}

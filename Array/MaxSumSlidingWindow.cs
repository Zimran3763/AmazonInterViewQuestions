using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStrings
{
    class MaxSumSlidingWindow
    {
        static int maxSum(int[] arr, int n, int k)
        {

            // n must be greater
            if (n < k)
            {
                Console.WriteLine("Invalid");
                return -1;
            }

            // Compute sum of first window of size k
            int max_sum = 0;
            for (int i = 0; i < k; i++)
                max_sum += arr[i];

            // Compute sums of remaining windows by
            // removing first element of previous
            // window and adding last element of
            // current window.
            int window_sum = max_sum;
            for (int i = k; i < n; i++)
            {
                window_sum += arr[i] - arr[i - k];
                // or you can also write like this
                //window_sum +=arr[i];
                //windoe_sum -=arr[i-k];

                max_sum = Math.Max(max_sum, window_sum);
            }

            return max_sum;
        }
    }
}

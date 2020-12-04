using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnlineAssessment
{
    public class KClosestPointToOrigin
    {
        public static int[][] KClosest(int[][] points, int K)
        {
            int N = points.Length;
            //create an array to put all the distance 
            int[] dists = new int[N];
            for (int i = 0; i < N; ++i)
                dists[i] = dist(points[i]);
            //sort the array so we would know the value first k closest point 
            Array.Sort(dists);

            //check the value of k number than whatever is equal or less than would be our result
            int distK = dists[K - 1];

            //create a jagged array where we are going to put our answers
            int[][] ans = new int[K][];
            
            int ansIndex = 0;
            for (int i = 0; i < N; ++i)
                //we need to call the function again so we would know what are the original index in sorted array
                if (dist(points[i]) <= distK)
                    ans[ansIndex++] = points[i];

          
            return ans;
        }

        public static int dist(int[] point)
        {
            return point[0] * point[0] + point[1] * point[1];

        }
    }
}

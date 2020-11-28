using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Given 2 lists a and b. Each element is a pair of integers where the first integer represents the unique id and the second integer represents a value.
Your task is to find an element from a and an element form b such that the sum of their values is less or equal to target and as close to target as possible. 
Return a list of ids of selected elements. If no pair is possible, return an empty list.

Example 1:

Input:
a = [[1, 2], [2, 4], [3, 6]]
b = [[1, 2]]
target = 7

Output: [[2, 1]]

Explanation:
There are only three combinations [1, 1], [2, 1], and [3, 1], which have a total sum of 4, 6 and 8, respectively.
Since 6 is the largest sum that does not exceed 7, [2, 1] is the optimal pair.
----------------------------------------------------------------------------------------------------
Each aircraft should be assigned two shipping routes at once: one forward route and one return route. Due to the complex scheduling of flight plans,all aircraft have a fixed maximum operating travel distance, and cannot be scheduled to fly a shipping route that requires more travel distance than the prescribed maximum operating travel distance.
The goal of the system is to optimize the total operating travel distance of a given aircraft.
A forward/return shipping route pair is considered to be “optimal” if there does not exist another pair that has a higher operating travel distance than this pair, and also has a total less than or equal to the maximum operating travel distance of the aircraft.

For example, if the aircraft has a maximum operating travel distance of 3000 miles,
a forward/return shipping route pair using a total of 2900 miles would be optimal if there does not exist a pair that uses a total operating travel distance of 3000 miles,
but would not be considered optimal if such a pair did exist.Your task is to write an algorithm to optimize the sets of forward/return shipping route pairs that allow the aircraft to be optimally utilized, given a list of forward shipping routes and a list of return shipping routes.

Examples 1:

maxTravelDist=7000
forwardRouteList=[[1,2000][2.4000][3,6000]]
returnRouteList=[[1,2000]]
Output: [[2,1]]
Examples 2:

maxTravelDist=10000
forwardRouteList=[[1,3000][2,5000][3,7000],[4,10000]
returnRouteList=[[1,2000][2,3000][3,4000][4,5000]]
Output: [[2,4],[3,2]]*/
namespace AmazonOnlineAssessment
{
    public class PrimeAirRoute
    {
        public class PairInt
        {
            public int first;
            public int second;
            public PairInt(int first, int second)
            {
                this.first = first;
                this.second = second;
            }
        }

        public static List<PairInt> getOptimizedUtilize(int maxTravelDist, List<PairInt> forwardRouteList, List<PairInt> returnRouteList)
        {
            List<PairInt> result = new List<PairInt>();
            int max = int.MinValue;
            for (int i = 0; i < forwardRouteList.Count; i++)
            {
                for (int j = 0; j < returnRouteList.Count; j++)
                {

                    int sum = forwardRouteList[i].second + returnRouteList[j].second;
                    if (sum <= maxTravelDist)
                    {
                        if (sum > max)
                        {
                            max = sum;
                            result = new List<PairInt>();
                            result.Add(new PairInt(forwardRouteList[i].first, returnRouteList[j].first));
                        }
                        else
                        {
                            result.Add(new PairInt(forwardRouteList[i].first, returnRouteList[j].first));
                        }
                    }
                }
            }
            return result;
        }
    }
}

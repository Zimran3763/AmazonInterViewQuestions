using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

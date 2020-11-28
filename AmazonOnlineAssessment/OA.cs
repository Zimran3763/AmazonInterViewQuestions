using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AmazonOnlineAssessment.PrimeAirRoute;

namespace AmazonOnlineAssessment
{
    public class OA
    {     
        public static void Main(string[] args)
        {
            int maxTravelDist = 7000;
            List<PairInt> forwardRouteList = new List<PairInt>()
            {
                new PairInt(1,2000),
                new PairInt(2,4000),
                new PairInt(3,6000)

            };
            List<PairInt> returnRouteList = new List<PairInt>()
            {
                new PairInt(1,2000)
            };
            getOptimizedUtilize(maxTravelDist, forwardRouteList, returnRouteList);
        }

    }
}

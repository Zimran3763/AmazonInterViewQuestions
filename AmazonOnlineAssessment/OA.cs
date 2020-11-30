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
            #region air route optimiation
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
            #endregion

            #region Amazon fresh promotion
            string[][] codeList = new string[][]
            {
                new string[] { "apple", "apple" },
                new string [] {"banana", "anything", "banana" }

            };

            string[] shoppingCart = new[] { "apple", "orange", "apple", "banana", "orange", "banana" };
            int res = AmazonFreshPromotion.isWinner(codeList, shoppingCart);
            #endregion

            #region Item In Conainer
            string s1 = "|**|*|*";
            int[] startIndices = new int[] { 1, 1 };
            int[] endIndices = new int[] { 5, 6 };
            ItemInContainer.NumberOfItems(s1, startIndices, endIndices);
            #endregion
        }

    }
}

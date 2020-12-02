using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnlineAssessment
{
    public class AutoScalePolicy
    {
        public static int finalInstance(int instance, List<int> averageUtil)
        {
            if (averageUtil.Count == 0 || averageUtil == null || instance == 0) return 0;

            int indexSeconds = 0;
            while (indexSeconds < averageUtil.Count())
            {

                int utilization = averageUtil[indexSeconds];
                //if utilization is greater than 60 and instance is not more than 2*10 to the power 8
                //then double the instance and add 10 sec pause and move index to 10sec + 1
                if (utilization > 60 && instance <= 2e8)
                {
                    instance = instance * 2;
                    indexSeconds = indexSeconds + 10;
                }
                //if utilization is less than 25 then make the instance half and add 10 sec and index would be on 10sec +1
                else if (utilization < 25 && instance > 1)
                {
                    instance = instance / 2;
                    indexSeconds = indexSeconds + 10;
                }
                else
                {
                    //increment the index by 1 sec and continue don't come out side because we don't need additional sec index in this case
                    indexSeconds = indexSeconds + 1;
                    continue;
                }
                // after 10sec index
                indexSeconds = indexSeconds + 1;
            }

            return instance;
        }
    }
}

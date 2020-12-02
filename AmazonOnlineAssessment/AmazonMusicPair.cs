using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnlineAssessment
{
    public class AmazonMusicPair
    {
        public int NumPairsDivisibleBy60(int[] time)
        {

            var mod = new int[60];
            int sum = 0;
            // when putting in an item, pair it with all the items put in before
            foreach (var t in time)
            {
                int seconds = t % 60;
                //if t%60 =0 then other one will also zero
                //if t%60 !=0 then logic would (60 - t)%60 would also not equal zero
                // add it to the sum if is there any value
                sum += mod[(60 - seconds) % 60];
                // increase the index value of remainder so if get the same index we can increase the count
                mod[seconds]++;
            }
            return sum;

        }
    }
}

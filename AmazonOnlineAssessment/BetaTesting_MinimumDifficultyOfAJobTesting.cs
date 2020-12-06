using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1335. Minimum Difficulty of a Job Schedule
Hard

332

23

Add to List

Share
You want to schedule a list of jobs in d days. Jobs are dependent (i.e To work on the i-th job, you have to finish all the jobs j where 0 <= j < i).

You have to finish at least one task every day. The difficulty of a job schedule is the sum of difficulties of each day of the d days. The difficulty of a day is the maximum difficulty of a job done in that day.

Given an array of integers jobDifficulty and an integer d. The difficulty of the i-th job is jobDifficulty[i].

Return the minimum difficulty of a job schedule. If you cannot find a schedule for the jobs return -1.
*/
namespace AmazonOnlineAssessment
{
    public class BetaTesting_MinimumDifficultyOfAJobTesting
    {
        public static int MinDifficulty(int[] jobDifficulty, int d)
        {
            int ndif = jobDifficulty.Length;
            //if jobs are less than days then return -1 
            if (ndif < d) return -1;
            //d here is day and n is job difficulty
            var dp = new int[d, ndif];
            //day 1 
            for (int day = 0; day < d; day++)
            {
                //difficulty on that day
                for (int jdif = day; jdif < ndif; jdif++)
                {
                    //first day 
                    if (day == 0)
                        //if this is a first job on the first day then assign the first job to dp
                        //other wise check max between previous and current
                        dp[0, jdif] = jdif == 0 ? jobDifficulty[0] : Math.Max(dp[0, jdif - 1], jobDifficulty[jdif]);
                    else
                    {
                        //this would  second job difficulty we have to skip the first day
                        // we have to assign the at least one difficulty on each day
                        int max = jobDifficulty[jdif];
                        dp[day, jdif] = int.MaxValue;
                        //now start from the next difficulty(i+1) difficulty again 
                        // decrease first day difficulty because in any case atleast one has to process on first day
                        for (int i = jdif - 1; i >= day - 1; i--)
                        {
                            //check if there is a job difficulty greater than the current difficulty before it
                            //if ther is replace it with max
                            //keep decreasing the i so we can find greater difficulty 
                            //like 11, 111, 22,---> in this example we start with current max 22 then we will go left check if is there anything greater than 22
                            //we will add this max to the previous day privious difficulty and check what we have currently is min or not and replace with min
                            max = Math.Max(max, jobDifficulty[i + 1]);
                            // add current max + previous max on last day
                            // check if current [d,n] value or the addition is min and replace the min on current[d,n]
                            dp[day, jdif] = Math.Min(dp[day, jdif], dp[day - 1, i] + max);
                        }
                    }
                }
            }

            return dp[d - 1, ndif - 1];
        }
    }
}

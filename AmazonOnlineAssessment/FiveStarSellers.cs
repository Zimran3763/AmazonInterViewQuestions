using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnlineAssessment
{
    public class FiveStarSellers
    {
        public static int fiveStar(int[][] ratings, int target)
        {
            int n = ratings.Length;
            //each seller threshhold 1* target /100 means total would be length * target /100
            double threshold = n * target / 100.0;
            double percentage = 0.00;

            //calculate each subarray rate and add it to the percentage
            for (int i = 0; i < n; i++)
            {
                double a = ratings[i][0];
                double b = ratings[i][1];
                double rate = a / b;
                percentage += rate;
            }
            int maxIndex = 0, res = 0;
            double diff = 0.00, maxDiff = Double.MinValue;
            //percentage would be less then threshold
            while (percentage < threshold)
            {
                for (int i = 0; i < n; i++)
                {
                    double a = ratings[i][0];
                    double b = ratings[i][1];
                    //before increment 1 reviews
                    double rate = a / b;
                    //if it's all five star then continue
                    if (rate == 1)
                    {
                        continue;
                    }
                    //add 1 review at a time
                    double x = ratings[i][0] + 1;
                    double y = ratings[i][1] + 1;

                    //after adding review
                    double updated = x / y;

                    //diff between rate before and after increment review
                    diff = updated - rate;

                    //compare subarray if difference is bigger then only update the max diff and max index
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                        maxIndex = i;
                    }
                }
                //add the diff in existing percentage
                percentage += maxDiff;

                //reset max diff
                maxDiff = Double.MinValue;

                //update the inserted rating in the array
                //like for 1/2 it would be 2/3
                ratings[maxIndex][0] = ratings[maxIndex][0] + 1;
                ratings[maxIndex][1] = ratings[maxIndex][1] + 1;

                //after inserting each comment increment the result
                res++;
            }
            return res;
        }
    }
}

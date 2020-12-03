using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnlineAssessment
{
    public class GIftingGroupFriendCircle
    {
        public static void Dfs(int[][] M, int[] visited, int i)
        {
            //check if person first i has any person(value = 1) near him means anyfriend [0][1], [0][1],[0][2]
            for (int j = 0; j < M.Length; j++)
            {
                // if [0][1], [0][1],[0][2] has 1 and also not visited then make it visited and start again for jth person again
                if (M[i][j] == 1 && visited[j] == 0)
                {
                    visited[j] = 1;
                    Dfs(M, visited, j);
                }
            }
        }
        public static int FindCircleNum(int[][] M)
        {
            // value = 1 means person is friend ; value = 0 not friend 
            // there are thre people in the m metrix so maximum we can have 3 circle if nobodys are friends to ceah other
            //make a array for a length of number of people which would be length of given jagged array length
            int[] visited = new int[M.Length];

            //friend circle count
            int count = 0;

            //start with 0 index means person on i=0 index 
            //and check with other person(each column) relation with him in 0 rows 
            for (int i = 0; i < M.Length; i++)
            {
                //check if this person already visited
                //if not then we need to visit it and it will create a circle(atleast for it self)
                if (visited[i] == 0)
                {
                    Dfs(M, visited, i);

                    count++;
                }
            }
            return count;
        }
    }
}

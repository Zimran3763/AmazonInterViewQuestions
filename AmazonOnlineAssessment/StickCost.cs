using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Given n ropes of different lengths, we need to connect these ropes into one rope.We can connect only 2 ropes at a time.The cost required to connect 2 ropes is equal to sum of their lengths. The length of this connected rope is also equal to the sum of their lengths. This process is repeated until n ropes are connected into a single rope. Find the min possible cost required to connect all ropes.


Example 1:


Input: ropes = [8, 4, 6, 12]
Output: 58
Explanation: The optimal way to connect ropes is as follows
1. Connect the ropes of length 4 and 6 (cost is 10). Ropes after connecting: [8, 10, 12]
2. Connect the ropes of length 8 and 10 (cost is 18). Ropes after connecting: [18, 12]
3. Connect the ropes of length 18 and 12 (cost is 30).
Total cost to connect the ropes is 10 + 18 + 30 = 58
Example 2:

Input: ropes = [20, 4, 8, 2]
Output: 54
Example 3:

Input: ropes = [1, 2, 5, 10, 35, 89]
Output: 224
Example 4:

Input: ropes = [2, 2, 3, 3]
Output: 20
//add into quue all the ropes length
queue => 1,3,5,8 cost = 0 totalCost = 0
// resultant queue will be null 
resQueue => {}
//pop queue if res is null and add both number and make it cost and 
//enque number into res and total
//repeat the same when count of queue is 0 and res is one means 
//sum of count >1
(1+3),5,8 cost = 1+3=4    totalCost = 0+4
resulQueue => {4}
(4+5),8 cost = 4+5=9      totalCost = 4+9=13
resulQueue => {9}
9+8 cost = 9+8=17         totalCost= 13+17=30
resulQueue => {17}*/
 namespace AmazonOnlineAssessment
{
    public class StickCost
    {
        public static int ConnectSticks(int[] sticks)
        {
            Array.Sort(sticks);
            int totalCost = 0;
            var listQueue = new Queue<int>(sticks);
            var summedQueue = new Queue<int>();
            while (listQueue.Count + summedQueue.Count > 1)
            {
                int cost = GetPriceOfTwoShortest(listQueue, summedQueue) + GetPriceOfTwoShortest(listQueue, summedQueue);
                summedQueue.Enqueue(cost);
                totalCost += cost;
            }
            return totalCost;
        }
        private static int GetPriceOfTwoShortest(Queue<int> lq, Queue<int> sq)
        {
            if (lq.Count == 0)
                return sq.Dequeue();
            if (sq.Count == 0)
                return lq.Dequeue();

            return lq.Peek() < sq.Peek() ? lq.Dequeue() : sq.Dequeue();

        }
    }
}

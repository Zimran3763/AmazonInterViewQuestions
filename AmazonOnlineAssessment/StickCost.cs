using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

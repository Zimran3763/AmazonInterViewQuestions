using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnlineAssessment
{
    public class Turnstile
    {
        public static int[] gate(int[] time, int[] direction)
        {
            var len = time.Length;
            var ins = new Queue<int>();
            var outs = new Queue<int>();
            for (var i = 0; i < len; i++)
            {
                if (direction[i] == 0)
                {
                    ins.Enqueue(i);
                }
                else
                {
                    outs.Enqueue(i);
                }
            }

            var res = new int[len];
            // next available time, add 1 sec after each pass
            int nt = 0;
            // decision
            var outFirst = true;
            //update the res list by in and out index value in time list if time list on in or out index is greater than the current available time 
            //otherwise update currentavailable time
            while (ins.Count != 0 && outs.Count != 0)
            {
                int i = ins.Peek();

                var o = outs.Peek();

                // if out person comes first in time
                if (outFirst && time[o] <= nt)
                {
                }
                //if in person comes first in time
                else if (!outFirst && time[i] <= nt)
                {
                }
                else
                {
                    // otherwise decide by who comes first, outperson take priority on tie
                    outFirst = time[o] <= time[i];
                }

                // popup if out is going first(means outfirst is true)
                int idx = outFirst ? outs.Dequeue() : ins.Dequeue();
                //put the max out of time array at idx index or available time
                res[idx] = Math.Max(nt, time[idx]);
                // update next available time
                nt = res[idx] + 1;
            }
            //if out list is empty
            while (ins.Count != 0)
            {
                var idx = ins.Dequeue();
                res[idx] = Math.Max(nt, time[idx]);
                //adding 1 sec after each pass
                nt = res[idx] + 1;
            }

            while (outs.Count != 0)
            {
                var idx = outs.Dequeue();
                res[idx] = Math.Max(nt, time[idx]);
                nt = res[idx] + 1;
            }
            return res;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *You are keeping score for a baseball game with strange rules. The game consists of several rounds, where the scores of past rounds may affect future rounds' scores.

At the beginning of the game, you start with an empty record. You are given a list of strings ops, where ops[i] is the ith operation you must apply to the record and is one of the following:

An integer x - Record a new score of x.
"+" - Record a new score that is the sum of the previous two scores. It is guaranteed there will always be two previous scores.
"D" - Record a new score that is double the previous score. It is guaranteed there will always be a previous score.
"C" - Invalidate the previous score, removing it from the record. It is guaranteed there will always be a previous score.
Return the sum of all the scores on the record.
 **/
namespace AmazonOnlineAssessment
{
    public class RoboticsChallengeBaseBallGame
    {
        public int CalPoints(string[] ops)
        {
            int sum = 0;
            Stack<int> st = new Stack<int>();

            foreach (var ch in ops)
            {
                //tryparse char to int
                // if score is int just add it
                int num;
                if (int.TryParse(ch, out num))
                {
                    st.Push(num);
                    sum += num;
                }
                //if it's + then insert sum of previous two score
                if (ch == "+")
                {
                    //check the top in stack 
                    int prev = st.Pop();
                    //check the second top int the stack
                    int prevPrev = st.Peek();
                    //calculate sum of top and second from top
                    sum += prev + prevPrev;
                    //insert previous first again
                    st.Push(prev);
                    //insert new score in stack 
                    st.Push(prev + prevPrev);
                }
                //double the previous score
                else if (ch == "D")
                {
                    //check top in stack and make it double and insert it in stack 
                    int prev = st.Peek();
                    st.Push(2 * prev);
                    //update the sum
                    sum += 2 * prev;
                }
                else if (ch == "C")
                {
                    //cancel the previous score by poping it from stack and minus it from sum
                    sum -= st.Pop();
                }
            }

            return sum;
        }
    }
}
}

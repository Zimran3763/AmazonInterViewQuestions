using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Amazon parses logs of user transactions/activity to flag fraudulent activity. The log file is represented as an Array of arrays. The arrays consist of the following data:

[<userid1> <userid2> <# of transactions>]

For example:

[345366 89921 45]
Note the data is space delimited

So, the log data would look like:

[
[345366 89921 45],
[029323 38239 23]
...
]
Write a function to parse the log data to find distinct users that meet or cross a certain threshold. The function will take in 2 inputs:

Input 1: Log data in form an array of arrays
Input 2: threshold as an integer

Output should be an array of userids that are sorted.

If same userid appears in the transaction as userid1 and userid2, it should count as one occurence, not two.

Example:
Input 1:

[
[345366 89921 45],
[029323 38239 23],
[38239 345366 15],
[029323 38239 77],
[345366 38239 23],
[029323 345366 13],
[38239 38239 23]
...
]
Input 2: 3

Ouput: [345366 , 38239, 029323]
*/
namespace AmazonOnlineAssessment
{
    public class TransactionLog
    {
        public static List<string> FradulentActivity(string[] input, int threshold)
        {
            var dict = new Dictionary<string, int>();
            foreach (var log in input)
            {
                var transactions = log.Split(' ');

                //make sure user1 and user2 are not smae
                if (!string.Equals(transactions[0], transactions[1]))
                {
                    dict[transactions[0]] = dict.ContainsKey(transactions[0]) ? dict[transactions[0]]++ : 1;
                }
                dict[transactions[1]] = dict.ContainsKey(transactions[1]) ? dict[transactions[1]]++ : 1;
            }

            return dict.Where(d => d.Value >= threshold).OrderByDescending(d => int.Parse(d.Key)).Select(d => d.Key).ToList();
        }
    }
}

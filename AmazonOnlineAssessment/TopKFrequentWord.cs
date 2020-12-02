using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnlineAssessment
{

    public class TopKFrequentWord
    {

        public static string[] getMostFrequentCommonwords1(string[] reviews, string[] keywords, int k)
        {
            Dictionary<string, int> frequencies = new Dictionary<string, int>();
            List<string> keywordList = keywords.ToList();

            //take out each review from array of review
            foreach (string review in reviews)
            {

                HashSet<string> encounteredWords = new HashSet<string>();
                foreach (var reviewWord in review.ToLower().Split(' '))
                {
                    if (!encounteredWords.Contains(reviewWord) && keywordList.Contains(reviewWord))
                    {
                        if (frequencies.ContainsKey(reviewWord))
                        {
                            frequencies[reviewWord]++;
                        }
                        else
                        {
                            frequencies.Add(reviewWord, 1);
                        }


                        encounteredWords.Add(reviewWord);
                    }
                }
            }

            KeyValuePair<string, int>[] test = frequencies.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(k).ToArray();

            return test.Select(x => x.Key).ToArray();
        }
        //Solution 2
        public static string[] getMostFrequentCommonwords(string[] reviews, string[] keywords, int k)
        {
            //Create dictionary and add all the keywords in it with 0 value
            Dictionary<string, int> keyword = new Dictionary<string, int>();
            foreach (var word in keywords)
            {
                keyword.Add(word, 0);
            }

            // split each review from reviews array
            foreach (var review in reviews)
            {
                //split word on the basis of space in selected above review from the reviews array
                foreach (var reviewWord in review.ToLower().Split(' '))
                {
                    //if reviewWord is not empty and it's in Dictionary than increase it's frequency by 1
                    if (reviewWord != string.Empty && keyword.ContainsKey(reviewWord))
                    {
                        keyword[reviewWord]++;
                    }
                }
            }

            // order all the key and value  and k value only
            //we can not return in keyvalue pair
            KeyValuePair<string, int>[] test = keyword.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(k).ToArray();

            //return Top k value 
            return test.Select(x => x.Key).ToArray();
        }
    }
}

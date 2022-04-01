using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnlineAssessment
{
    public class MostCommonWord
    {
        public string MostCommonWord1(string paragraph, string[] banned)
        {
            string result = string.Empty;
            //replace all the symbols
            paragraph = paragraph.Replace("!", " ")
                                  .Replace("?", " ")
                                  .Replace("'", " ")
                                  .Replace(",", " ")
                                  .Replace(";", " ")
                                  .Replace(".", " ")
                                  .Trim();

            //Hashtable to store all banned item so we can ignore it while adding word into               //dictionary
            HashSet<string> bannedTable = new HashSet<string>();

            //To store all the word from the string  except banned        
            Dictionary<string, int> countSubstring = new Dictionary<string, int>();

            //Add all the word from banned array to hashtable
            foreach (var item in banned)
                bannedTable.Add(item.ToLower());

            foreach (var item in paragraph.Split(' '))
            {


                if (item != string.Empty && !bannedTable.Contains(item.ToLower()))
                {
                    if (!countSubstring.ContainsKey(item.ToLower()))
                        countSubstring.Add(item.ToLower(), 1);

                    countSubstring[item.ToLower()] += 1;
                }

            }

            // maximum value key would be our answer
            foreach (var item in countSubstring.Keys)
            {

                if (countSubstring[item] == countSubstring.Values.Max())
                {
                    result = item;

                }
            }
            return result;
        }
    }
}
/*
 * int numFeatures = 6;
 * int topFeatures = 2;
 * string [] possibleFeatures =  new []{ "storage","battery","hover","alexa","waterproof","solar"};
 * int numFeatureRequests = 7;
 * string [] featureRequests = new []{"I wish my Kindle had even more storage!","I wish the battery life on my Kindle lasted 2 years.",Tread in the bath andwould enjoy a waterproof Kindle"."Waterproof and increased battery aremy top two requests.", "I want to take my Kindle into the shower.Waterproof please waterproof !". "It would be neat if my Kindle wouldhover on my desk when not in use.""How cool would it be if my Kindle charged in the sun via solar power?"}
 * public static List popularNFeatures(int numFeatures, int topFeatures, string [] possibleFeatures, int numFeatureRequests, string [] featureRequests)
{
    var frequentWords = new List();
    var hash = new HashSet();
    var dictionary = new Dictionary<string, int>();

    foreach(var str in possibleFeatures)
    {
        var strToLower = str.ToLower();
        if(!hash.Contains(strToLower))
        { 
            hash.Add(strToLower); 
        }
    }

    foreach(var item in featureRequests)
    {
        var strAttray = item.Replace(",", " ")
                            .Replace(".", " ")
                            .Replace("!", " ")
                            .Replace("?", " ")
                            .Replace(";", " ")
                            .Replace("'", " ")
                            .ToLower()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach(var feature in  new HashSet<string>(strAttray))
        {
            if(hash.Contains(feature))
            {
                if(!dictionary.ContainsKey(feature))
                {
                    dictionary.Add(feature, 0);
                }
                dictionary[feature]++;
            }
        }
    }

        frequentWords = dictionary.OrderByDescending(x => x.Value).Select(o => o.Key).Take(topFeatures).ToList();

        return frequentWords;
 */

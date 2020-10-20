using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStrings
{
    public class PossibleFeatures
    {
        public static List<string> possibleFeaturesInComment(string comment , string[] possibleFeatures)
        {
            comment = comment.Replace(",", " ").Replace("\"", " ").Replace(".", " ").Replace("?", " ").Trim();
          
            Dictionary<string,int> featureSet = new Dictionary<string, int>();
            for (int i = 0; i < possibleFeatures.Length; i++)
                featureSet.Add(possibleFeatures[i].ToLower(),0);

            foreach(var item in comment.Split(' '))
            {
                if(item != string.Empty && featureSet.ContainsKey(item.ToLower()))
                {
                    featureSet[item.ToLower()]++;
                    
                }
            }

            
            List<KeyValuePair<string, int>> test =
            featureSet.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(2).ToList();

            //  return top k keys from dict  
            return test.Select(x => x.Key).ToList();
        }
    }
}

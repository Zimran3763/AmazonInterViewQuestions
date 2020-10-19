using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStrings
{
    public class IntegerToItsEnglishWord
    {
        private static readonly string[] LESS_THAN_20 = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        private static readonly string[] TENS = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
        private static readonly string[] THOUSANDS = {"", "Thousand", "Million", "Billion"};

        public static string numberToWords(int num)
        {
            if (num == 0) 
                return "Zero";

            int i = 0;
            string words = "";

            while (num > 0)
            {
                //if number is giving zero after deviding by 1000 which 1000 number than we just need to print 1 and increase i to 1 so it can print thousands
                if (num % 1000 != 0)
                    words = Helper(num % 1000) + THOUSANDS[i] + " " + words;
                
                //divisible 
                num /= 1000;
                i++;
            }
            //trim the last space if you want
            return words.Trim();
        }

        private static string Helper(int num)
        {
            if (num == 0)
                return "";
            //add space at the end beacuse if it's bigger than 1000 than we need space btween words
            //get last digit in word
            else if (num < 20)
                return LESS_THAN_20[num] + " ";
            //get hundred digit in word
            else if (num < 100)
                return TENS[num / 10] + " " + Helper(num % 10);
            //get a first digit in hundred like in 867 eight and append hundred and get 67 by calling helper again
            else
                return LESS_THAN_20[num / 100] + " Hundred " + Helper(num % 100);
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_answers
{
    public class ArraysandStringsAnswers
    {
        public int RemoveElement(int[] nums, int val)
        {

            int pointer = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[pointer] = nums[i];
                    pointer++;
                }
            }
            return pointer;
        }

        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int buyPointer = 0;
            for(int i = 0;i < prices.Length;i++)
            {
                if (prices[i] < prices[buyPointer]) {
                    buyPointer = i;
                }
                else if (prices[i] - prices[buyPointer] > maxProfit) {
                    maxProfit = prices[i] - prices[buyPointer];
                }
            }
            return maxProfit;
        }

        public int LengthOfLastWord(string s)
        {
            string newString = s.Trim();
            string[] strings = newString.Split(' ');
            if(strings.Length == 0)
            {
                return 0;
            }
            return strings[strings.Length - 1].Length;

            //int length = 0; 
            //// get index of last letter
            //int lastLetterIndex = s.Length - 1;
            //while (s[lastLetterIndex] == ' ' && lastLetterIndex >=0)
            //{
            //    lastLetterIndex--;
            //}
            //// find length of last word
            //while (s[lastLetterIndex] != ' ' && lastLetterIndex >= 0) {
            //    length++;
                
            //    lastLetterIndex--;
            //    if (lastLetterIndex < 0)
            //    {
            //        break;
            //    }
            //}
            //return length;
        }
    }

   
}

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
            for (int i = 0; i < nums.Length; i++)
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
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < prices[buyPointer])
                {
                    buyPointer = i;
                }
                else if (prices[i] - prices[buyPointer] > maxProfit)
                {
                    maxProfit = prices[i] - prices[buyPointer];
                }
            }
            return maxProfit;
        }

        public int LengthOfLastWord(string s)
        {
            string newString = s.Trim();
            string[] strings = newString.Split(' ');
            if (strings.Length == 0)
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

        public int MaxProfitTwo(int[] prices)
        {
            int maxProfit = 0;
            int buyPointer = 0;
            int sellPointer = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                int price = prices[i];
                // if the price drops, we sell and add the profit to our earnings. We then reset the sliding window. 
                if (price < prices[sellPointer])
                {
                    maxProfit += prices[sellPointer] - prices[buyPointer];
                    buyPointer = i;
                    sellPointer = i;
                }
                else if (price > prices[sellPointer])
                {
                    sellPointer = i;
                }
            }
            // check for remaining profits to be made
            if (buyPointer != sellPointer)
            {
                maxProfit += prices[sellPointer] - prices[buyPointer];
            }
            return maxProfit;
        }

        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int sum = gas[^1] - cost[^1];
            int maxIndex = gas.Length - 1;
            int maxSum = sum;
            for (int i = gas.Length - 2; i >= 0; i--)
            {
                sum += (gas[i] - cost[i]);
                if (sum > maxSum)
                {
                    maxIndex = i;
                    maxSum = sum;
                }

            }
            if (sum < 0) return -1;
            return maxIndex;
        }

        //public string Convert(string s, int numRows)
        //{
        //    int oddStep = (numRows * 2) - 2;
        //    int evenStep = numRows
        //    char[] chars = s.ToCharArray();
        //    string result = "";
        //    for(int i = 0; i < numRows; i++)
        //    {
        //        int index = i;
        //        while(index < s.Length)
        //        {
        //            result += chars[index];
        //            index += step;
        //        }
        //    }
        //    return result;
        //}
    }


}

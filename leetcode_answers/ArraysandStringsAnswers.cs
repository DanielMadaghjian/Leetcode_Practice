using Serilog;
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
            Log.Debug("Iterating through the array at {now}", DateTime.Now);
            for (int i = 0; i < nums.Length; i++)
            {
                Log.Warning("array could be empty {now}", DateTime.Now);
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
            //while (s[lastLetterIndex] == ' ' && lastLetterIndex >= 0)
            //{
            //    lastLetterIndex--;
            //}
            //// find length of last word
            //while (s[lastLetterIndex] != ' ' && lastLetterIndex >= 0)
            //{
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

        public string Convert(string s, int numRows)
        {
            // unchanged
            if (numRows == 1) return s;

            int step = (numRows * 2) - 2;
            char[] chars = s.ToCharArray();
            string result = "";

            // add first row
            int j = 0;
            while(j < s.Length)
            {
                result += chars[j];
                j += step;
            }
            
            // add consective rows to result
            for (int i = 1; i < numRows; i++)
            {
                int p1 = i;
                int p2 = step - i;
                while (p1 < s.Length)
                {
                    if (p1 == p2)
                    {
                        result += chars[p1];
                    }
                    else
                    {
                        if(p1 < s.Length)
                        {
                            result += chars[p1];
                        }
                        if(p2 < s.Length)
                        {
                            result += chars[p2];
                        }
                        
                    }
                    p1 += step;
                    p2 += step;
                }
            }
            return result;
        }

        public int StrStr(string haystack, string needle)
        {
            if (haystack.Length < needle.Length)
            {
                return -1;
            }
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                string sub = haystack.Substring(i, needle.Length);
                if (string.Equals(sub, needle))
                {
                    return i;
                }
            }
            return -1;
        }

        public int HIndex(int[] citations)
        {
            int[] sortedArrDesc = citations.OrderByDescending(c => c).ToArray();
            int currentMaxH = 0;
            int maxH = 0;
            for(int i = 0; i <  sortedArrDesc.Length; i++)
            {
                int value = sortedArrDesc[i];
                if(value >= i+1)
                {
                    currentMaxH++;
                    if(currentMaxH > maxH)
                    {
                        maxH = currentMaxH;
                    }
                }
                else
                {
                    currentMaxH = 0;
                }
            }
            return maxH;
        }

        public Boolean IsPalindrome(string s)
        {
            string modifiedString = RemoveWhiteSpaces(s);
            modifiedString = RemoveNonAlphaNum(modifiedString);
            modifiedString = modifiedString.ToLower();
            int p1 = 0;
            int p2 = modifiedString.Length - 1;
            while(p1 <= p2)
            {
                if (modifiedString[p1] != modifiedString[p2])
                {
                    return false;
                }
                p1++;
                p2--;
            }
            return true;
        }
        public string RemoveNonAlphaNum(string input)
        {
            char[] arr = input.ToCharArray();

            arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c)
                                              || char.IsWhiteSpace(c)
                                              || c == '-')));
            return new string(arr);
        }
        public string RemoveWhiteSpaces(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int maxLength = 0;
            int currentLength = 0;
            int startingIndex = 0;
            int currentIndex = 0;
            while(currentIndex < s.Length)
            {
                // if char is not duplicate
                if (set.Add(s[currentIndex])){
                    currentLength++;
                    if(currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                    currentIndex++;
                }
                // if it is a duplicate -> reset 
                else
                {
                    set.Clear();
                    currentLength = 0;
                    currentIndex = startingIndex;
                    startingIndex++;
                }
            }
            return maxLength;
        }
    }


}

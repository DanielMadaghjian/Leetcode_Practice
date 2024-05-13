using leetcode_answers;
using NUnit.Framework;
using System.Diagnostics;

namespace LeetcodeTests
{
    public class ArraysAndStringsTests
    {
        public ArraysandStringsAnswers answer = new ArraysandStringsAnswers();

        [Test]
        public void RemoveElementTests()
        {
            int[] nums1 = [3, 2, 2, 3];
            int val1 = 3;
            int[] nums2 = [0, 1, 2, 2, 3, 0, 4, 2];
            int val2 = 2;

            int result1 = answer.RemoveElement(nums1, val1);
            Assert.That(result1, Is.EqualTo(2));
            int result2 = answer.RemoveElement(nums2, val2);
            Assert.That(result2, Is.EqualTo(5));

        }

        [Test]
        public void MaxProfitTests()
        {
            int[] prices1 = [7, 1, 5, 3, 6, 4];
            int[] prices2 = [7, 6, 4, 3, 1];

            Assert.That(answer.MaxProfit(prices1), Is.EqualTo(5));
            Assert.That(answer.MaxProfit(prices2), Is.EqualTo(0));
        }
        [Test]
        public void TestLengthOfLastWord()
        {
            string s1 = "Hello World";
            string s2 = "   fly me   to   the moon  ";
            string s3 = "s";
            Assert.That(answer.LengthOfLastWord(s1), Is.EqualTo(5));
            Assert.That(answer.LengthOfLastWord(s2), Is.EqualTo(4));
            Assert.That(answer.LengthOfLastWord(s3), Is.EqualTo(1));

        }
        [Test]
        public void TestMaxProfitTwo()
        {
            int[] prices1 = [7, 1, 5, 3, 6, 4];
            int[] prices2 = [1, 2, 3, 4, 5];
            int[] prices3 = [7, 6, 4, 3, 1];

            Assert.That(answer.MaxProfitTwo(prices1), Is.EqualTo(7));
            Assert.That(answer.MaxProfitTwo(prices2), Is.EqualTo(4));
            Assert.That(answer.MaxProfitTwo(prices3), Is.EqualTo(0));
        }

        [Test]
        public void TestCanCompleteCircuit()
        {
            int[] gas1 = [1, 2, 3, 4, 5];
            int[] cost1 = [3, 4, 5, 1, 2];

            int[] gas2 = [2, 3, 4];
            int[] cost2 = [3, 4, 3];
            Assert.That(answer.CanCompleteCircuit(gas1, cost1), Is.EqualTo(3));
            Assert.That(answer.CanCompleteCircuit(gas2, cost2), Is.EqualTo(-1));

        }

        [Test]
        public void TestConvert()
        {
            string s1 = "PAYPALISHIRING";
            int r1 = 3;

            string s2 = "PAYPALISHIRING";
            int r2 = 4;

            //Assert.That(answer.Convert(s1, r1), Is.EqualTo("PAHNAPLSIIGYIR"));
            //Assert.That(answer.Convert(s2, r2), Is.EqualTo("PINALSIGYAHRPI"));

        }
    }
}
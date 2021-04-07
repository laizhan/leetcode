using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace leetcode_lib._1__两数之和.Tests
{
    [TestClass()]
    public class two_sumTests
    {
        two_sum instance = new two_sum();

        [TestMethod()]
        public void TwoSumTest()
        {
            int[] test1 = new int[] { 2, 7, 11, 15 };
            int[] test1TrueResult = new int[] { 0, 1 };
            var test1Result = instance.TwoSum(test1, 9);
            Assert.AreEqual(test1TrueResult.Sum(), test1Result.Sum());
        }
    }
}
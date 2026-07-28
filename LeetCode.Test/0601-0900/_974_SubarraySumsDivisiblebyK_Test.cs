using LeetCode._0601_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0601_0900
{
    [TestClass]
    public class _974_SubarraySumsDivisiblebyK_Test
    {
        [TestMethod]
        public void Example1_ShouldReturn7()
        {
            var solution = new _974_SubarraySumsDivisiblebyK();

            int[] nums = { 4, 5, 0, -2, -3, 1 };
            int k = 5;

            int result = solution.SubarraysDivByK(nums, k);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void SingleElement_NotDivisible_ShouldReturn0()
        {
            var solution = new _974_SubarraySumsDivisiblebyK();

            int[] nums = { 5 };
            int k = 9;

            int result = solution.SubarraysDivByK(nums, k);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SingleElement_Divisible_ShouldReturn1()
        {
            var solution = new _974_SubarraySumsDivisiblebyK();

            int[] nums = { 10 };
            int k = 5;

            int result = solution.SubarraysDivByK(nums, k);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void AllZeros_ShouldReturnAllSubarrays()
        {
            var solution = new _974_SubarraySumsDivisiblebyK();

            int[] nums = { 0, 0, 0 };
            int k = 5;

            int result = solution.SubarraysDivByK(nums, k);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void AllNumbersDivisibleByK_ShouldReturnAllSubarrays()
        {
            var solution = new _974_SubarraySumsDivisiblebyK();

            int[] nums = { 5, 10, 15 };
            int k = 5;

            int result = solution.SubarraysDivByK(nums, k);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void NegativeNumbers_ShouldReturnCorrectCount()
        {
            var solution = new _974_SubarraySumsDivisiblebyK();

            int[] nums = { -1, 2, 9 };
            int k = 2;

            int result = solution.SubarraysDivByK(nums, k);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MixedPositiveNegative_ShouldReturnCorrectCount()
        {
            var solution = new _974_SubarraySumsDivisiblebyK();

            int[] nums = { -5, 5 };
            int k = 5;

            int result = solution.SubarraysDivByK(nums, k);

            Assert.AreEqual(3, result);
        }
    }
}

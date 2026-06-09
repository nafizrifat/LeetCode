using LeetCode._0301_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0301_600
{
    [TestClass]
    public class _454_4SumII_Test
    {
        [TestMethod]
        public void FourSumCount_Example1_Returns2()
        {
            // Arrange
            var solution = new _454_4SumII();

            int[] nums1 = { 1, 2 };
            int[] nums2 = { -2, -1 };
            int[] nums3 = { -1, 2 };
            int[] nums4 = { 0, 2 };

            // Act
            int result = solution.FourSumCount(nums1, nums2, nums3, nums4);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FourSumCount_Example2_Returns1()
        {
            // Arrange
            var solution = new _454_4SumII();

            int[] nums1 = { 0 };
            int[] nums2 = { 0 };
            int[] nums3 = { 0 };
            int[] nums4 = { 0 };

            // Act
            int result = solution.FourSumCount(nums1, nums2, nums3, nums4);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FourSumCount_NoCombination_Returns0()
        {
            // Arrange
            var solution = new _454_4SumII();

            int[] nums1 = { 1 };
            int[] nums2 = { 1 };
            int[] nums3 = { 1 };
            int[] nums4 = { 1 };

            // Act
            int result = solution.FourSumCount(nums1, nums2, nums3, nums4);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FourSumCount_MultipleZeros_Returns16()
        {
            // Arrange
            var solution = new _454_4SumII();

            int[] nums1 = { 0, 0 };
            int[] nums2 = { 0, 0 };
            int[] nums3 = { 0, 0 };
            int[] nums4 = { 0, 0 };

            // Act
            int result = solution.FourSumCount(nums1, nums2, nums3, nums4);

            // Assert
            // 2 * 2 * 2 * 2 = 16 possible index combinations
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void FourSumCount_WithDuplicates_Returns6()
        {
            // Arrange
            var solution = new _454_4SumII();

            int[] nums1 = { 1, 1 };
            int[] nums2 = { -1, -1 };
            int[] nums3 = { 0, 0 };
            int[] nums4 = { 0 };

            // Act
            int result = solution.FourSumCount(nums1, nums2, nums3, nums4);

            // Assert
            // nums1 + nums2 gives zero 4 times
            // nums3 has 2 zeros and nums4 has 1 zero
            // total = 4 * 2 * 1 = 8
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void FourSumCount_MixedPositiveNegativeNumbers_Returns4()
        {
            // Arrange
            var solution = new _454_4SumII();

            int[] nums1 = { -1, -1 };
            int[] nums2 = { -1, 1 };
            int[] nums3 = { -1, 1 };
            int[] nums4 = { 1, -1 };

            // Act
            int result = solution.FourSumCount(nums1, nums2, nums3, nums4);

            // Assert
            Assert.AreEqual(6, result);
        }
    }
}

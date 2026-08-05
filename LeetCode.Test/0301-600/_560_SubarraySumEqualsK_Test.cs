using LeetCode._0301_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0301_600
{
    [TestClass]
    public class _560_SubarraySumEqualsK_Test
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 1, 1 }, 2, 2)]
        [DataRow(new int[] { 1, 2, 3 }, 3, 2)]
        [DataRow(new int[] { 1 }, 1, 1)]
        [DataRow(new int[] { 1 }, 0, 0)]
        [DataRow(new int[] { -1, -1, 1 }, 0, 1)]
        [DataRow(new int[] { 1, -1, 0 }, 0, 3)]
        [DataRow(new int[] { 0, 0, 0 }, 0, 6)]
        [DataRow(new int[] { 3, 4, 7, 2, -3, 1, 4, 2 }, 7, 4)]
        [DataRow(new int[] { -1, -1, -1 }, -2, 2)]
        [DataRow(new int[] { 5, -2, 3 }, 6, 1)]
        public void SubarraySum_ReturnsExpectedCount(
            int[] nums,
            int k,
            int expected)
        {
            // Arrange
            var solution = new _560_SubarraySumEqualsK();

            // Act
            int actual = solution.SubarraySum(nums, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

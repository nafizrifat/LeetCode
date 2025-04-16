using LeetCode._0001_0300;
using System;
using System.Collections.Generic;

namespace LeetCode.Test._0001_0300
{
    [TestClass]
    public class _001_TwoSum_Test
    {
        [TestMethod]
        public void TestTwoSum_WithValidInput_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            // The expected indices for the numbers 2 and 7 (order does not matter).
            int[] expected = new int[] { 0, 1 };

            var solution = new _001_TwoSum();

            // Act
            int[] result = solution.TwoSum(nums, target);

            // Assert
            Assert.IsNotNull(result, "Result should not be null.");
            Assert.AreEqual(2, result.Length, "Result should contain exactly two indices.");

            // Since the order of the indices might vary, check that both expected indices are present.
            bool hasFirstIndex = (result[0] == expected[0] || result[1] == expected[0]);
            bool hasSecondIndex = (result[0] == expected[1] || result[1] == expected[1]);

            Assert.IsTrue(hasFirstIndex && hasSecondIndex,
                $"Expected indices {expected[0]} and {expected[1]} but got [{result[0]}, {result[1]}].");
        }

    }
}

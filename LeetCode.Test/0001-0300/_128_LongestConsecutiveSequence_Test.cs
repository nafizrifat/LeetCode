using LeetCode._0001_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0001_0300
{
    [TestClass]
    public class _128_LongestConsecutiveSequence_Test
    {
        [TestMethod]
        public void LongestConsecutive_Example1_Returns4()
        {
            // Arrange
            var solution = new _128_LongestConsecutiveSequence();
            int[] nums = { 100, 4, 200, 1, 3, 2 };

            // Act
            int result = solution.LongestConsecutive(nums);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void LongestConsecutive_Example2_Returns9()
        {
            // Arrange
            var solution = new _128_LongestConsecutiveSequence();
            int[] nums = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

            // Act
            int result = solution.LongestConsecutive(nums);

            // Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void LongestConsecutive_WithDuplicates_Returns3()
        {
            // Arrange
            var solution = new _128_LongestConsecutiveSequence();
            int[] nums = { 1, 0, 1, 2 };

            // Act
            int result = solution.LongestConsecutive(nums);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void LongestConsecutive_EmptyArray_Returns0()
        {
            // Arrange
            var solution = new _128_LongestConsecutiveSequence();
            int[] nums = { };

            // Act
            int result = solution.LongestConsecutive(nums);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void LongestConsecutive_SingleNumber_Returns1()
        {
            // Arrange
            var solution = new _128_LongestConsecutiveSequence();
            int[] nums = { 5 };

            // Act
            int result = solution.LongestConsecutive(nums);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void LongestConsecutive_NegativeNumbers_Returns4()
        {
            // Arrange
            var solution = new _128_LongestConsecutiveSequence();
            int[] nums = { -1, -2, -3, -4, 10 };

            // Act
            int result = solution.LongestConsecutive(nums);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void LongestConsecutive_UnorderedNegativeAndPositiveNumbers_Returns7()
        {
            // Arrange
            var solution = new _128_LongestConsecutiveSequence();
            int[] nums = { -2, -1, 0, 1, 2, 3, 4, 10 };

            // Act
            int result = solution.LongestConsecutive(nums);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void LongestConsecutive_NoConsecutiveNumbers_Returns1()
        {
            // Arrange
            var solution = new _128_LongestConsecutiveSequence();
            int[] nums = { 10, 30, 50, 70 };

            // Act
            int result = solution.LongestConsecutive(nums);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void LongestConsecutive_AllSameNumbers_Returns1()
        {
            // Arrange
            var solution = new _128_LongestConsecutiveSequence();
            int[] nums = { 2, 2, 2, 2, 2 };

            // Act
            int result = solution.LongestConsecutive(nums);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void LongestConsecutive_MultipleSequences_Returns5()
        {
            // Arrange
            var solution = new _128_LongestConsecutiveSequence();
            int[] nums = { 10, 5, 12, 3, 55, 30, 4, 11, 2, 1 };

            // Act
            int result = solution.LongestConsecutive(nums);

            // Assert
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void LongestConsecutive_LaterSequenceIsLongest_Returns4()
        {
            // Arrange
            var solution = new _128_LongestConsecutiveSequence();
            int[] nums = { 10, 20, 30, 1, 2, 100, 101, 102, 103 };

            // Act
            int result = solution.LongestConsecutive(nums);

            // Assert
            Assert.AreEqual(4, result);
        }

    }
}



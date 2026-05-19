using LeetCode._0001_0300;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LeetCode.Test._0001_0300
{
    [TestClass]
    public class _217_ContainsDuplicate_Test
    {
        [TestMethod]
        public void TestContainsDuplicate_WithDuplicateValues_ReturnsTrue()
        {
            // Arrange
            int[] nums = new int[] { 1, 2, 3, 1 };

            var solution = new _217_ContainsDuplicate();

            // Act
            bool result = solution.ContainsDuplicate(nums);

            // Assert
            Assert.IsTrue(result, "Array contains duplicate value 1, so result should be true.");
        }

        [TestMethod]
        public void TestContainsDuplicate_WithNoDuplicateValues_ReturnsFalse()
        {
            // Arrange
            int[] nums = new int[] { 1, 2, 3, 4 };

            var solution = new _217_ContainsDuplicate();

            // Act
            bool result = solution.ContainsDuplicate(nums);

            // Assert
            Assert.IsFalse(result, "Array does not contain duplicate values, so result should be false.");
        }

        [TestMethod]
        public void TestContainsDuplicate_WithMultipleDuplicateValues_ReturnsTrue()
        {
            // Arrange
            int[] nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            var solution = new _217_ContainsDuplicate();

            // Act
            bool result = solution.ContainsDuplicate(nums);

            // Assert
            Assert.IsTrue(result, "Array contains multiple duplicate values, so result should be true.");
        }

        [TestMethod]
        public void TestContainsDuplicate_WithSingleElement_ReturnsFalse()
        {
            // Arrange
            int[] nums = new int[] { 1 };

            var solution = new _217_ContainsDuplicate();

            // Act
            bool result = solution.ContainsDuplicate(nums);

            // Assert
            Assert.IsFalse(result, "Single element array cannot contain duplicate values.");
        }

        [TestMethod]
        public void TestContainsDuplicate_WithNegativeDuplicateValues_ReturnsTrue()
        {
            // Arrange
            int[] nums = new int[] { -1, -2, -3, -1 };

            var solution = new _217_ContainsDuplicate();

            // Act
            bool result = solution.ContainsDuplicate(nums);

            // Assert
            Assert.IsTrue(result, "Array contains duplicate negative value -1, so result should be true.");
        }

        [TestMethod]
        public void TestContainsDuplicate_WithZeroDuplicate_ReturnsTrue()
        {
            // Arrange
            int[] nums = new int[] { 0, 1, 2, 0 };

            var solution = new _217_ContainsDuplicate();

            // Act
            bool result = solution.ContainsDuplicate(nums);

            // Assert
            Assert.IsTrue(result, "Array contains duplicate value 0, so result should be true.");
        }

        [TestMethod]
        public void TestContainsDuplicate_WithEmptyArray_ReturnsFalse()
        {
            // Arrange
            int[] nums = new int[] { };

            var solution = new _217_ContainsDuplicate();

            // Act
            bool result = solution.ContainsDuplicate(nums);

            // Assert
            Assert.IsFalse(result, "Empty array does not contain duplicate values.");
        }
    }
}
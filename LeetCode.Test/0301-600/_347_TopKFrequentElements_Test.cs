using LeetCode._0301_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0301_600
{
    [TestClass]
    public class _347_TopKFrequentElements_Test
    {
        private _347_TopKFrequentElements _solution;

        [TestInitialize]
        public void Setup()
        {
            _solution = new _347_TopKFrequentElements();
        }

        [TestMethod]
        public void TopKFrequent_Example1_ReturnsTopTwoFrequentElements()
        {
            // Arrange
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;

            // Act
            int[] result = _solution.TopKFrequent(nums, k);

            // Assert
            CollectionAssert.AreEquivalent(new int[] { 1, 2 }, result);
        }

        [TestMethod]
        public void TopKFrequent_Example2_ReturnsSingleElement()
        {
            // Arrange
            int[] nums = { 1 };
            int k = 1;

            // Act
            int[] result = _solution.TopKFrequent(nums, k);

            // Assert
            CollectionAssert.AreEquivalent(new int[] { 1 }, result);
        }

        [TestMethod]
        public void TopKFrequent_WithNegativeNumbers_ReturnsMostFrequentElements()
        {
            // Arrange
            int[] nums = { -1, -1, -1, 2, 2, 3 };
            int k = 2;

            // Act
            int[] result = _solution.TopKFrequent(nums, k);

            // Assert
            CollectionAssert.AreEquivalent(new int[] { -1, 2 }, result);
        }

        [TestMethod]
        public void TopKFrequent_WhenKEqualsNumberOfUniqueElements_ReturnsAllUniqueElements()
        {
            // Arrange
            int[] nums = { 4, 1, 2, 2, 3, 3 };
            int k = 4;

            // Act
            int[] result = _solution.TopKFrequent(nums, k);

            // Assert
            CollectionAssert.AreEquivalent(new int[] { 1, 2, 3, 4 }, result);
        }

        [TestMethod]
        public void TopKFrequent_WithSameFrequency_ReturnsAnyValidTopKElements()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4 };
            int k = 2;

            // Act
            int[] result = _solution.TopKFrequent(nums, k);

            // Assert
            Assert.AreEqual(k, result.Length);
            Assert.IsTrue(result.All(x => nums.Contains(x)));
            Assert.AreEqual(result.Distinct().Count(), result.Length);
        }

        [TestMethod]
        public void TopKFrequent_WithLargeFrequencyDifference_ReturnsCorrectElement()
        {
            // Arrange
            int[] nums = { 5, 5, 5, 5, 1, 1, 2, 3 };
            int k = 1;

            // Act
            int[] result = _solution.TopKFrequent(nums, k);

            // Assert
            CollectionAssert.AreEquivalent(new int[] { 5 }, result);
        }

        [TestMethod]
        public void TopKFrequent_WithMultipleTopElements_ReturnsCorrectTopK()
        {
            // Arrange
            int[] nums = { 1, 1, 2, 2, 2, 3, 3, 4 };
            int k = 3;

            // Frequencies:
            // 2 -> 3 times
            // 1 -> 2 times
            // 3 -> 2 times
            // 4 -> 1 time

            // Act
            int[] result = _solution.TopKFrequent(nums, k);

            // Assert
            CollectionAssert.AreEquivalent(new int[] { 1, 2, 3 }, result);
        }
    }
}

using LeetCode._0301_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0301_600
{
    [TestClass]
    public class _349_IntersectionOfTwoArrays_Test
    {
        [TestMethod]
        public void TestIntersection_WithCommonElements_ReturnsUniqueIntersection()
        {
            // Arrange
            var solution = new _349_IntersectionOfTwoArrays();
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };

            // Act
            int[] result = solution.Intersection(nums1, nums2);

            // Assert
            CollectionAssert.AreEquivalent(new int[] { 2 }, result);
        }

        [TestMethod]
        public void TestIntersection_WithMultipleCommonElements_ReturnsUniqueValues()
        {
            // Arrange
            var solution = new _349_IntersectionOfTwoArrays();
            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };

            // Act
            int[] result = solution.Intersection(nums1, nums2);

            // Assert
            CollectionAssert.AreEquivalent(new int[] { 9, 4 }, result);
        }

        [TestMethod]
        public void TestIntersection_WithNoCommonElements_ReturnsEmptyArray()
        {
            // Arrange
            var solution = new _349_IntersectionOfTwoArrays();
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 4, 5, 6 };

            // Act
            int[] result = solution.Intersection(nums1, nums2);

            // Assert
            Assert.AreEqual(0, result.Length);
        }

        [TestMethod]
        public void TestIntersection_WithDuplicateValues_ReturnsOnlyUniqueIntersection()
        {
            // Arrange
            var solution = new _349_IntersectionOfTwoArrays();
            int[] nums1 = { 1, 1, 1, 2, 2 };
            int[] nums2 = { 1, 1, 2, 2, 3 };

            // Act
            int[] result = solution.Intersection(nums1, nums2);

            // Assert
            CollectionAssert.AreEquivalent(new int[] { 1, 2 }, result);
        }

        [TestMethod]
        public void TestIntersection_WithEmptyFirstArray_ReturnsEmptyArray()
        {
            // Arrange
            var solution = new _349_IntersectionOfTwoArrays();
            int[] nums1 = { };
            int[] nums2 = { 1, 2 };

            // Act
            int[] result = solution.Intersection(nums1, nums2);

            // Assert
            Assert.AreEqual(0, result.Length);
        }

        [TestMethod]
        public void TestIntersection_WithEmptySecondArray_ReturnsEmptyArray()
        {
            // Arrange
            var solution = new _349_IntersectionOfTwoArrays();
            int[] nums1 = { 1, 2 };
            int[] nums2 = { };

            // Act
            int[] result = solution.Intersection(nums1, nums2);

            // Assert
            Assert.AreEqual(0, result.Length);
        }
    }
}

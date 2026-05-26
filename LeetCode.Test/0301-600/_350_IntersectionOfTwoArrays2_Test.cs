using LeetCode._0301_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0301_600
{
    [TestClass]
    public class _350_IntersectionOfTwoArrays2_Test
    {
        [TestMethod]
        public void TestIntersection_WithExample1_ReturnsCorrectResult()
        {
            // Arrange
            var solution = new _350_IntersectionOfTwoArrays2();

            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };

            // Act
            int[] result = solution.Intersect(nums1, nums2);

            // Assert
            CollectionAssert.AreEqual(
                new int[] { 2, 2 },
                result.OrderBy(x => x).ToArray());
        }

        [TestMethod]
        public void TestIntersection_WithExample2_ReturnsCorrectResult()
        {
            // Arrange
            var solution = new _350_IntersectionOfTwoArrays2();

            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };

            // Act
            int[] result = solution.Intersect(nums1, nums2);

            // Assert
            CollectionAssert.AreEqual(
                new int[] { 4, 9 },
                result.OrderBy(x => x).ToArray());
        }

        [TestMethod]
        public void TestIntersection_WithNoMatch_ReturnsEmptyArray()
        {
            // Arrange
            var solution = new _350_IntersectionOfTwoArrays2();

            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 4, 5, 6 };

            // Act
            int[] result = solution.Intersect(nums1, nums2);

            // Assert
            CollectionAssert.AreEqual(
                new int[] { },
                result);
        }

        [TestMethod]
        public void TestIntersection_WithOneEmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            var solution = new _350_IntersectionOfTwoArrays2();

            int[] nums1 = { };
            int[] nums2 = { 1, 2, 3 };

            // Act
            int[] result = solution.Intersect(nums1, nums2);

            // Assert
            CollectionAssert.AreEqual(
                new int[] { },
                result);
        }

        [TestMethod]
        public void TestIntersection_WithBothEmptyArrays_ReturnsEmptyArray()
        {
            // Arrange
            var solution = new _350_IntersectionOfTwoArrays2();

            int[] nums1 = { };
            int[] nums2 = { };

            // Act
            int[] result = solution.Intersect(nums1, nums2);

            // Assert
            CollectionAssert.AreEqual(
                new int[] { },
                result);
        }

        [TestMethod]
        public void TestIntersection_WithDuplicateValues_ReturnsCorrectCount()
        {
            // Arrange
            var solution = new _350_IntersectionOfTwoArrays2();

            int[] nums1 = { 1, 2, 2, 2, 3 };
            int[] nums2 = { 2, 2 };

            // Act
            int[] result = solution.Intersect(nums1, nums2);

            // Assert
            CollectionAssert.AreEqual(
                new int[] { 2, 2 },
                result.OrderBy(x => x).ToArray());
        }

        [TestMethod]
        public void TestIntersection_WithNegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var solution = new _350_IntersectionOfTwoArrays2();

            int[] nums1 = { -1, -2, -2, 1 };
            int[] nums2 = { -2, -2 };

            // Act
            int[] result = solution.Intersect(nums1, nums2);

            // Assert
            CollectionAssert.AreEqual(
                new int[] { -2, -2 },
                result.OrderBy(x => x).ToArray());
        }
    }
}

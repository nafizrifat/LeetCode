using LeetCode._0301_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0301_600
{
    [TestClass]
    public class _451_SortCharactersByFrequency_Test
    {
        [TestMethod]
        public void FrequencySort_WithTree_ReturnsSortedByFrequency()
        {
            // Arrange
            var solution = new _451_SortCharactersByFrequency();

            // Act
            string result = solution.FrequencySort("tree");

            // Assert
            Assert.AreEqual(4, result.Length);
            Assert.IsTrue(IsSameCharacters("tree", result));
            Assert.IsTrue(IsSortedByFrequencyDescending(result));
        }

        [TestMethod]
        public void FrequencySort_WithCccAaa_ReturnsSortedByFrequency()
        {
            // Arrange
            var solution = new _451_SortCharactersByFrequency();

            // Act
            string result = solution.FrequencySort("cccaaa");

            // Assert
            Assert.AreEqual(6, result.Length);
            Assert.IsTrue(IsSameCharacters("cccaaa", result));
            Assert.IsTrue(IsSortedByFrequencyDescending(result));

            // Both are valid because 'c' and 'a' appear 3 times
            Assert.IsTrue(result == "cccaaa" || result == "aaaccc");
        }

        [TestMethod]
        public void FrequencySort_WithAabb_ReturnsSortedByFrequency()
        {
            // Arrange
            var solution = new _451_SortCharactersByFrequency();

            // Act
            string result = solution.FrequencySort("Aabb");

            // Assert
            Assert.AreEqual(4, result.Length);
            Assert.IsTrue(IsSameCharacters("Aabb", result));
            Assert.IsTrue(IsSortedByFrequencyDescending(result));

            // 'b' appears twice, so result should start with "bb"
            Assert.IsTrue(result.StartsWith("bb"));
        }

        [TestMethod]
        public void FrequencySort_WithSingleCharacter_ReturnsSameCharacter()
        {
            // Arrange
            var solution = new _451_SortCharactersByFrequency();

            // Act
            string result = solution.FrequencySort("z");

            // Assert
            Assert.AreEqual("z", result);
        }

        [TestMethod]
        public void FrequencySort_WithAllSameCharacters_ReturnsSameString()
        {
            // Arrange
            var solution = new _451_SortCharactersByFrequency();

            // Act
            string result = solution.FrequencySort("aaaa");

            // Assert
            Assert.AreEqual("aaaa", result);
        }

        [TestMethod]
        public void FrequencySort_WithMultipleFrequencies_ReturnsDescendingFrequencyOrder()
        {
            // Arrange
            var solution = new _451_SortCharactersByFrequency();

            // Act
            string result = solution.FrequencySort("raaeaedere");

            // Assert
            Assert.AreEqual(10, result.Length);
            Assert.IsTrue(IsSameCharacters("raaeaedere", result));
            Assert.IsTrue(IsSortedByFrequencyDescending(result));
        }

        [TestMethod]
        public void FrequencySort_WithEmptyString_ReturnsEmptyString()
        {
            // Arrange
            var solution = new _451_SortCharactersByFrequency();

            // Act
            string result = solution.FrequencySort("");

            // Assert
            Assert.AreEqual("", result);
        }

        private bool IsSameCharacters(string input, string result)
        {
            Dictionary<char, int> inputFrequency = input
                .GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());

            Dictionary<char, int> resultFrequency = result
                .GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());

            return inputFrequency.Count == resultFrequency.Count &&
                   inputFrequency.All(x =>
                       resultFrequency.ContainsKey(x.Key) &&
                       resultFrequency[x.Key] == x.Value);
        }

        private bool IsSortedByFrequencyDescending(string result)
        {
            Dictionary<char, int> frequency = result
                .GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());

            for (int i = 1; i < result.Length; i++)
            {
                if (frequency[result[i]] > frequency[result[i - 1]])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using LeetCode._0001_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0001_0300
{
    [TestClass]
    public class _49_GroupAnagrams_Test
    {
        private _49_GroupAnagrams _solution;

        [TestInitialize]
        public void Setup()
        {
            _solution = new _49_GroupAnagrams();
        }

        [TestMethod]
        public void GroupAnagrams_Example1_ReturnsGroupedAnagrams()
        {
            // Arrange
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            // Act
            IList<IList<string>> actual = _solution.GroupAnagrams(strs);

            // Assert
            AssertGroupsAreEqual(
                new List<List<string>>
                {
                    new List<string> { "eat", "tea", "ate" },
                    new List<string> { "tan", "nat" },
                    new List<string> { "bat" }
                },
                actual
            );
        }

        [TestMethod]
        public void GroupAnagrams_EmptyString_ReturnsSingleGroup()
        {
            // Arrange
            string[] strs = { "" };

            // Act
            IList<IList<string>> actual = _solution.GroupAnagrams(strs);

            // Assert
            AssertGroupsAreEqual(
                new List<List<string>>
                {
                    new List<string> { "" }
                },
                actual
            );
        }

        [TestMethod]
        public void GroupAnagrams_SingleCharacter_ReturnsSingleGroup()
        {
            // Arrange
            string[] strs = { "a" };

            // Act
            IList<IList<string>> actual = _solution.GroupAnagrams(strs);

            // Assert
            AssertGroupsAreEqual(
                new List<List<string>>
                {
                    new List<string> { "a" }
                },
                actual
            );
        }

        [TestMethod]
        public void GroupAnagrams_NoAnagrams_ReturnsSeparateGroups()
        {
            // Arrange
            string[] strs = { "abc", "def", "ghi" };

            // Act
            IList<IList<string>> actual = _solution.GroupAnagrams(strs);

            // Assert
            AssertGroupsAreEqual(
                new List<List<string>>
                {
                    new List<string> { "abc" },
                    new List<string> { "def" },
                    new List<string> { "ghi" }
                },
                actual
            );
        }

        [TestMethod]
        public void GroupAnagrams_AllAreAnagrams_ReturnsOneGroup()
        {
            // Arrange
            string[] strs = { "abc", "bca", "cab", "acb" };

            // Act
            IList<IList<string>> actual = _solution.GroupAnagrams(strs);

            // Assert
            AssertGroupsAreEqual(
                new List<List<string>>
                {
                    new List<string> { "abc", "bca", "cab", "acb" }
                },
                actual
            );
        }

        [TestMethod]
        public void GroupAnagrams_WithDuplicateWords_GroupsDuplicatesTogether()
        {
            // Arrange
            string[] strs = { "eat", "eat", "tea", "bat", "tab" };

            // Act
            IList<IList<string>> actual = _solution.GroupAnagrams(strs);

            // Assert
            AssertGroupsAreEqual(
                new List<List<string>>
                {
                    new List<string> { "eat", "eat", "tea" },
                    new List<string> { "bat", "tab" }
                },
                actual
            );
        }

        [TestMethod]
        public void GroupAnagrams_WithDifferentLengthWords_ReturnsCorrectGroups()
        {
            // Arrange
            string[] strs = { "a", "aa", "aaa", "b", "ab", "ba" };

            // Act
            IList<IList<string>> actual = _solution.GroupAnagrams(strs);

            // Assert
            AssertGroupsAreEqual(
                new List<List<string>>
                {
                    new List<string> { "a" },
                    new List<string> { "aa" },
                    new List<string> { "aaa" },
                    new List<string> { "b" },
                    new List<string> { "ab", "ba" }
                },
                actual
            );
        }

        private static void AssertGroupsAreEqual(
            List<List<string>> expected,
            IList<IList<string>> actual)
        {
            var normalizedExpected = Normalize(expected);
            var normalizedActual = Normalize(actual);

            CollectionAssert.AreEqual(normalizedExpected, normalizedActual);
        }

        private static List<string> Normalize(IEnumerable<IEnumerable<string>> groups)
        {
            return groups
                .Select(group => string.Join(",", group.OrderBy(x => x)))
                .OrderBy(x => x)
                .ToList();
        }
    }
}

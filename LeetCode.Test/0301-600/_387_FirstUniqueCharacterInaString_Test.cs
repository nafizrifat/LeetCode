using LeetCode._0301_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0331_600
{
    [TestClass]
    public class _387_FirstUniqueCharacterInaString_Test
    {
        [TestMethod]
        public void FirstUniqChar_WithLeetCode_Returns0()
        {
            // Arrange
            var solution = new _387_FirstUniqueCharacterInaString();

            // Act
            int result = solution.FirstUniqChar("leetcode");

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FirstUniqChar_WithLoveLeetCode_Returns2()
        {
            // Arrange
            var solution = new _387_FirstUniqueCharacterInaString();

            // Act
            int result = solution.FirstUniqChar("loveleetcode");

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FirstUniqChar_WithAllRepeatingCharacters_ReturnsMinus1()
        {
            // Arrange
            var solution = new _387_FirstUniqueCharacterInaString();

            // Act
            int result = solution.FirstUniqChar("aabb");

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void FirstUniqChar_WithSingleCharacter_Returns0()
        {
            // Arrange
            var solution = new _387_FirstUniqueCharacterInaString();

            // Act
            int result = solution.FirstUniqChar("z");

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FirstUniqChar_WithUniqueCharacterAtEnd_ReturnsLastIndex()
        {
            // Arrange
            var solution = new _387_FirstUniqueCharacterInaString();

            // Act
            int result = solution.FirstUniqChar("aabbc");

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void FirstUniqChar_WithEmptyString_ReturnsMinus1()
        {
            // Arrange
            var solution = new _387_FirstUniqueCharacterInaString();

            // Act
            int result = solution.FirstUniqChar("");

            // Assert
            Assert.AreEqual(-1, result);
        }

    }
}

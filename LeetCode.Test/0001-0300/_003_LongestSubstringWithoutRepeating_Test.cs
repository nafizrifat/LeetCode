using LeetCode._0001_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0001_0300
{
    [TestClass]
    public class _003_LongestSubstringWithoutRepeating_Test
    {
        [TestMethod]
        public void LengthOfLongestSubstring_Example1_Returns3()
        {
            // Arrange
            var solution = new _003_LongestSubstringWithoutRepeating();
            string s = "abcabcbb";

            // Act
            int result = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_Example2_Returns1()
        {
            // Arrange
            var solution = new _003_LongestSubstringWithoutRepeating();
            string s = "bbbbb";

            // Act
            int result = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_Example3_Returns3()
        {
            // Arrange
            var solution = new _003_LongestSubstringWithoutRepeating();
            string s = "pwwkew";

            // Act
            int result = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_EmptyString_Returns0()
        {
            // Arrange
            var solution = new _003_LongestSubstringWithoutRepeating();
            string s = "";

            // Act
            int result = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_SingleCharacter_Returns1()
        {
            // Arrange
            var solution = new _003_LongestSubstringWithoutRepeating();
            string s = "a";

            // Act
            int result = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_AllUniqueCharacters_ReturnsLength()
        {
            // Arrange
            var solution = new _003_LongestSubstringWithoutRepeating();
            string s = "abcdef";

            // Act
            int result = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_RepeatedCharactersAfterUniquePart_Returns3()
        {
            // Arrange
            var solution = new _003_LongestSubstringWithoutRepeating();
            string s = "dvdf";

            // Act
            int result = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_RepeatingCharacterInMiddle_Returns2()
        {
            // Arrange
            var solution = new _003_LongestSubstringWithoutRepeating();
            string s = "abba";

            // Act
            int result = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_StringWithSpaces_Returns3()
        {
            // Arrange
            var solution = new _003_LongestSubstringWithoutRepeating();
            string s = "a b a";

            // Act
            int result = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_LongInputWithRepeats_Returns5()
        {
            // Arrange
            var solution = new _003_LongestSubstringWithoutRepeating();
            string s = "abcdeafgh";

            // Act
            int result = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(8, result);
        }
    }
}

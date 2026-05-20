using LeetCode._0001_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0001_0300
{
    [TestClass]
    public class _242_ValidAnagram_Test
    {
        private readonly _242_ValidAnagram _solution = new _242_ValidAnagram();

        [TestMethod]
        public void IsAnagram_WithValidAnagram_ReturnsTrue()
        {
            // Arrange
            string s = "anagram";
            string t = "nagaram";

            // Act
            bool result = _solution.IsAnagram(s, t);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsAnagram_WithInvalidAnagram_ReturnsFalse()
        {
            // Arrange
            string s = "rat";
            string t = "car";

            // Act
            bool result = _solution.IsAnagram(s, t);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsAnagram_WithDifferentLengths_ReturnsFalse()
        {
            // Arrange
            string s = "abc";
            string t = "ab";

            // Act
            bool result = _solution.IsAnagram(s, t);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsAnagram_WithSameSingleCharacter_ReturnsTrue()
        {
            // Arrange
            string s = "a";
            string t = "a";

            // Act
            bool result = _solution.IsAnagram(s, t);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsAnagram_WithDifferentSingleCharacter_ReturnsFalse()
        {
            // Arrange
            string s = "a";
            string t = "b";

            // Act
            bool result = _solution.IsAnagram(s, t);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsAnagram_WithRepeatedCharacters_ReturnsTrue()
        {
            // Arrange
            string s = "aacc";
            string t = "ccac";

            // Act
            bool result = _solution.IsAnagram(s, t);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsAnagram_WithEmptyEquivalentLogic_ReturnsTrue()
        {
            // Arrange
            string s = "zz";
            string t = "zz";

            // Act
            bool result = _solution.IsAnagram(s, t);

            // Assert
            Assert.IsTrue(result);
        }
    }
}


using LeetCode._0901_1200;

namespace LeetCode.Test._0901_1200
{
    [TestClass]
    public class _1047_RemoveAllAdjacentDuplicatesInString_Test
    {
        [TestMethod]
        public void RemoveDuplicates_Example1_ReturnsCa()
        {
            // Arrange
            string s = "abbaca";
            var solution = new _1047_RemoveAllAdjacentDuplicatesInString();

            // Act
            string result = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual("ca", result);
        }

        [TestMethod]
        public void RemoveDuplicates_Example2_ReturnsAy()
        {
            // Arrange
            string s = "azxxzy";
            var solution = new _1047_RemoveAllAdjacentDuplicatesInString();

            // Act
            string result = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual("ay", result);
        }

        [TestMethod]
        public void RemoveDuplicates_NoAdjacentDuplicates_ReturnsOriginalString()
        {
            // Arrange
            string s = "abc";
            var solution = new _1047_RemoveAllAdjacentDuplicatesInString();

            // Act
            string result = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual("abc", result);
        }

        [TestMethod]
        public void RemoveDuplicates_AllCharactersRemoved_ReturnsEmptyString()
        {
            // Arrange
            string s = "aabb";
            var solution = new _1047_RemoveAllAdjacentDuplicatesInString();

            // Act
            string result = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void RemoveDuplicates_NewDuplicateCreatedAfterRemoval_ReturnsEmptyString()
        {
            // Arrange
            string s = "abba";
            var solution = new _1047_RemoveAllAdjacentDuplicatesInString();

            // Act
            string result = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void RemoveDuplicates_SingleCharacter_ReturnsSameCharacter()
        {
            // Arrange
            string s = "a";
            var solution = new _1047_RemoveAllAdjacentDuplicatesInString();

            // Act
            string result = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void RemoveDuplicates_ThreeSameCharacters_ReturnsOneCharacter()
        {
            // Arrange
            string s = "aaa";
            var solution = new _1047_RemoveAllAdjacentDuplicatesInString();

            // Act
            string result = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void RemoveDuplicates_MultipleChainRemovals_ReturnsEmptyString()
        {
            // Arrange
            string s = "abccba";
            var solution = new _1047_RemoveAllAdjacentDuplicatesInString();

            // Act
            string result = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void RemoveDuplicates_DuplicatesAtBeginning_ReturnsCd()
        {
            // Arrange
            string s = "aabbcd";
            var solution = new _1047_RemoveAllAdjacentDuplicatesInString();

            // Act
            string result = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual("cd", result);
        }

        [TestMethod]
        public void RemoveDuplicates_DuplicatesAtEnd_ReturnsAb()
        {
            // Arrange
            string s = "abcc";
            var solution = new _1047_RemoveAllAdjacentDuplicatesInString();

            // Act
            string result = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual("ab", result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._0001_0300;

namespace LeetCode.Test._0001_0300
{
    [TestClass]
    public class _020_ValidParentheses_Test
    {
        [TestMethod]
        public void IsValid_SinglePairParentheses_ReturnsTrue()
        {
            // Arrange
            string s = "()";
            var solution = new _020_ValidParentheses();

            // Act
            bool result = solution.IsValid(s);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValid_AllBracketTypes_ReturnsTrue()
        {
            // Arrange
            string s = "()[]{}";
            var solution = new _020_ValidParentheses();

            // Act
            bool result = solution.IsValid(s);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValid_NestedBrackets_ReturnsTrue()
        {
            // Arrange
            string s = "{[()]}";
            var solution = new _020_ValidParentheses();

            // Act
            bool result = solution.IsValid(s);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValid_DifferentNestedBrackets_ReturnsTrue()
        {
            // Arrange
            string s = "([])";
            var solution = new _020_ValidParentheses();

            // Act
            bool result = solution.IsValid(s);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValid_MismatchedBrackets_ReturnsFalse()
        {
            // Arrange
            string s = "(]";
            var solution = new _020_ValidParentheses();

            // Act
            bool result = solution.IsValid(s);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_WrongClosingOrder_ReturnsFalse()
        {
            // Arrange
            string s = "([)]";
            var solution = new _020_ValidParentheses();

            // Act
            bool result = solution.IsValid(s);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_MissingClosingBracket_ReturnsFalse()
        {
            // Arrange
            string s = "((";
            var solution = new _020_ValidParentheses();

            // Act
            bool result = solution.IsValid(s);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_ClosingBracketWithoutOpening_ReturnsFalse()
        {
            // Arrange
            string s = ")";
            var solution = new _020_ValidParentheses();

            // Act
            bool result = solution.IsValid(s);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_ComplexValidBrackets_ReturnsTrue()
        {
            // Arrange
            string s = "({[]})[]{}";
            var solution = new _020_ValidParentheses();

            // Act
            bool result = solution.IsValid(s);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValid_ComplexInvalidBrackets_ReturnsFalse()
        {
            // Arrange
            string s = "{[}]";
            var solution = new _020_ValidParentheses();

            // Act
            bool result = solution.IsValid(s);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_MismatchedClosingBracket_ReturnsFalse()
        {
            // Arrange
            string s = "(])";
            var solution = new _020_ValidParentheses();

            // Act
            bool result = solution.IsValid(s);

            // Assert
            Assert.IsFalse(result);
        }
    }
}

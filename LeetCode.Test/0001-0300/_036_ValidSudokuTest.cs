using LeetCode._0001_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0001_0300
{
    [TestClass]
    public class _036_ValidSudokuTest
    {
        [TestMethod]
        public void IsValidSudoku_ValidBoard_ReturnsTrue()
        {
            // Arrange
            var solution = new _036_ValidSudoku();

            char[][] board =
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            // Act
            bool result = solution.IsValidSudoku(board);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidSudoku_DuplicateInRow_ReturnsFalse()
        {
            // Arrange
            var solution = new _036_ValidSudoku();

            char[][] board =
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '5' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            // Act
            bool result = solution.IsValidSudoku(board);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidSudoku_DuplicateInColumn_ReturnsFalse()
        {
            // Arrange
            var solution = new _036_ValidSudoku();

            char[][] board =
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '5', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            // Act
            bool result = solution.IsValidSudoku(board);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidSudoku_DuplicateInThreeByThreeBox_ReturnsFalse()
        {
            // Arrange
            var solution = new _036_ValidSudoku();

            char[][] board =
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '5', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            // Act
            bool result = solution.IsValidSudoku(board);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidSudoku_EmptyBoard_ReturnsTrue()
        {
            // Arrange
            var solution = new _036_ValidSudoku();

            char[][] board =
            {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            // Act
            bool result = solution.IsValidSudoku(board);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidSudoku_SingleNumberOnly_ReturnsTrue()
        {
            // Arrange
            var solution = new _036_ValidSudoku();

            char[][] board =
            {
                new char[] { '1', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            // Act
            bool result = solution.IsValidSudoku(board);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidSudoku_DuplicateInTopMiddleBox_ReturnsFalse()
        {
            // Arrange
            var solution = new _036_ValidSudoku();

            char[][] board =
            {
        new char[] { '.', '.', '.', '5', '.', '.', '.', '.', '.' },
        new char[] { '.', '.', '.', '.', '5', '.', '.', '.', '.' },
        new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },

        new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
        new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
        new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },

        new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
        new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
        new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' }
    };

            // Act
            bool result = solution.IsValidSudoku(board);

            // Assert
            Assert.IsFalse(result);
        }
    }
}

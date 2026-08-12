using LeetCode._0601_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0601_0900
{
    [TestClass]
    public class _682_BaseballGame_Test
    {
        [TestMethod]
        public void CalPoints_Example1_Returns30()
        {
            // Arrange
            string[] operations = { "5", "2", "C", "D", "+" };
            var solution = new _682_BaseballGame();

            // Act
            int result = solution.CalPoints(operations);

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void CalPoints_Example2_Returns27()
        {
            // Arrange
            string[] operations = { "5", "-2", "4", "C", "D", "9", "+", "+" };
            var solution = new _682_BaseballGame();

            // Act
            int result = solution.CalPoints(operations);

            // Assert
            Assert.AreEqual(27, result);
        }

        [TestMethod]
        public void CalPoints_SingleScore_ReturnsScore()
        {
            // Arrange
            string[] operations = { "10" };
            var solution = new _682_BaseballGame();

            // Act
            int result = solution.CalPoints(operations);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void CalPoints_CancelPreviousScore_ReturnsRemainingScore()
        {
            // Arrange
            string[] operations = { "5", "10", "C" };
            var solution = new _682_BaseballGame();

            // Act
            int result = solution.CalPoints(operations);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void CalPoints_DoublePreviousScore_ReturnsCorrectTotal()
        {
            // Arrange
            string[] operations = { "5", "D" };
            var solution = new _682_BaseballGame();

            // Act
            int result = solution.CalPoints(operations);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void CalPoints_AddPreviousTwoScores_ReturnsCorrectTotal()
        {
            // Arrange
            string[] operations = { "5", "10", "+" };
            var solution = new _682_BaseballGame();

            // Act
            int result = solution.CalPoints(operations);

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void CalPoints_NegativeScores_ReturnsCorrectTotal()
        {
            // Arrange
            string[] operations = { "-5", "-2", "+" };
            var solution = new _682_BaseballGame();

            // Act
            int result = solution.CalPoints(operations);

            // Assert
            Assert.AreEqual(-14, result);
        }

        [TestMethod]
        public void CalPoints_MultipleDoubleOperations_ReturnsCorrectTotal()
        {
            // Arrange
            string[] operations = { "2", "D", "D" };
            var solution = new _682_BaseballGame();

            // Act
            int result = solution.CalPoints(operations);

            // Assert
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void CalPoints_CancelThenDouble_ReturnsCorrectTotal()
        {
            // Arrange
            string[] operations = { "5", "10", "C", "D" };
            var solution = new _682_BaseballGame();

            // Act
            int result = solution.CalPoints(operations);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void CalPoints_ComplexOperations_ReturnsCorrectTotal()
        {
            // Arrange
            string[] operations = { "10", "20", "+", "D", "C" };
            var solution = new _682_BaseballGame();

            // Act
            int result = solution.CalPoints(operations);

            // Assert
            // Scores:
            // 10
            // 20
            // +  = 30
            // D  = 60
            // C  removes 60
            // Total = 10 + 20 + 30 = 60
            Assert.AreEqual(60, result);
        }
    }
}

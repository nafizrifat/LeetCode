using LeetCode._0001_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0001_0300
{
    [TestClass]
    public class _169_MajorityElement_Test
    {
        [TestMethod]
        public void TestMajorityElement_NormalCase1()
        {
            // Arrange
            int[] nums = { 3, 2, 3 };

            // Act
            int result = new _169_MajorityElement().MajorityElement(nums);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMajorityElement_NormalCase2()
        {
            // Arrange
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };

            // Act
            int result = new _169_MajorityElement().MajorityElement(nums);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMajorityElement_SingleElement()
        {
            // Arrange
            int[] nums = { 1 };

            // Act
            int result = new _169_MajorityElement().MajorityElement(nums);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMajorityElement_MajorityAtBeginning()
        {
            // Arrange
            int[] nums = { 5, 5, 5, 2, 3 };

            // Act
            int result = new _169_MajorityElement().MajorityElement(nums);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMajorityElement_MajorityAtEnd()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 4, 4, 4 };

            // Act
            int result = new _169_MajorityElement().MajorityElement(nums);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMajorityElement_NegativeNumbers()
        {
            // Arrange
            int[] nums = { -1, -1, -1, 2, 3 };

            // Act
            int result = new _169_MajorityElement().MajorityElement(nums);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMajorityElement_AllSameNumbers()
        {
            // Arrange
            int[] nums = { 7, 7, 7, 7, 7 };

            // Act
            int result = new _169_MajorityElement().MajorityElement(nums);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestMajorityElement_LargeValues()
        {
            // Arrange
            int[] nums = { 999999, 1, 999999, 999999 };

            // Act
            int result = new _169_MajorityElement().MajorityElement(nums);

            // Assert
            Assert.AreEqual(999999, result);
        }
    }
}

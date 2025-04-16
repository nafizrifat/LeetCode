using LeetCode._0001_0300;

namespace LeetCode.Test._0001_0300
{
    [TestClass]
    public class _002_AddTwoNumbers_Test
    {
        [TestMethod]
        public void TwoSumTest_Ordered()
        {
            // Arrange
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            ListNode expected = new ListNode(7, new ListNode(0, new ListNode(8, null)));

            var solution = new _002_AddTwoNumbers();

            // Act
            var result = solution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.IsTrue(Helper.AreEqual(expected, result), "The linked list result is not equal to the expected output.");
        }
    }
}

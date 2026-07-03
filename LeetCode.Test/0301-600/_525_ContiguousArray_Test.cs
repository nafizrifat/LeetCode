
using LeetCode._0301_0600;

namespace LeetCode.Test._0301_600
{
    [TestClass]
    public class _525_ContiguousArray_Test
    {
        private _525_ContiguousArray _solution = null!;

        [TestInitialize]
        public void Setup()
        {
            _solution = new _525_ContiguousArray();
        }

        [DataTestMethod]
        [DataRow(new int[] { 0, 1 }, 2)]
        [DataRow(new int[] { 0, 1, 0 }, 2)]
        [DataRow(new int[] { 0, 1, 1, 1, 1, 1, 0, 0, 0 }, 6)]
        public void FindMaxLength_LeetCodeExamples_ReturnsExpectedResult(
            int[] nums,
            int expected)
        {
            int actual = _solution.FindMaxLength(nums);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(new int[] { 0 }, 0)]
        [DataRow(new int[] { 1 }, 0)]
        public void FindMaxLength_SingleElement_ReturnsZero(
            int[] nums,
            int expected)
        {
            int actual = _solution.FindMaxLength(nums);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(new int[] { 0, 0, 0, 0 }, 0)]
        [DataRow(new int[] { 1, 1, 1, 1 }, 0)]
        public void FindMaxLength_AllSameValues_ReturnsZero(
            int[] nums,
            int expected)
        {
            int actual = _solution.FindMaxLength(nums);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(new int[] { 0, 1, 0, 1, 0, 1 }, 6)]
        [DataRow(new int[] { 1, 0, 1, 0 }, 4)]
        [DataRow(new int[] { 0, 0, 1, 1 }, 4)]
        public void FindMaxLength_EntireArrayIsBalanced_ReturnsArrayLength(
            int[] nums,
            int expected)
        {
            int actual = _solution.FindMaxLength(nums);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 1, 1, 0, 0 }, 4)]
        [DataRow(new int[] { 0, 0, 0, 1, 1, 1, 1 }, 6)]
        [DataRow(new int[] { 0, 0, 1, 0, 0, 0, 1, 1 }, 6)]
        [DataRow(new int[] { 1, 0, 0, 1, 0, 1, 1 }, 6)]
        public void FindMaxLength_LongestBalancedSectionIsNotEntireArray_ReturnsExpectedResult(
            int[] nums,
            int expected)
        {
            int actual = _solution.FindMaxLength(nums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMaxLength_MaximumSizeBalancedArray_ReturnsFullLength()
        {
            int[] nums = new int[100_000];

            // First 50,000 values remain 0.
            for (int i = 50_000; i < nums.Length; i++)
            {
                nums[i] = 1;
            }

            int actual = _solution.FindMaxLength(nums);

            Assert.AreEqual(100_000, actual);
        }
    }
}

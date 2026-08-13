using LeetCode._1201_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._1201_1500
{
    [TestClass]
    public class _1441_BuildanArrayWithStackOperations_Test
    {
        [TestMethod]
        public void BuildArray_Target123_N3_ReturnsOnlyPush()
        {
            int[] target = { 1, 2, 3 };
            int n = 3;

            var solution = new _1441_BuildanArrayWithStackOperations();

            IList<string> result = solution.BuildArray(target, n);

            CollectionAssert.AreEqual(
                new List<string> { "Push", "Push", "Push" },
                result.ToList());
        }

        [TestMethod]
        public void BuildArray_Target13_N3_ReturnsPushPopPush()
        {
            int[] target = { 1, 3 };
            int n = 3;

            var solution = new _1441_BuildanArrayWithStackOperations();

            IList<string> result = solution.BuildArray(target, n);

            CollectionAssert.AreEqual(
                new List<string> { "Push", "Push", "Pop", "Push" },
                result.ToList());
        }

        [TestMethod]
        public void BuildArray_Target12_N4_StopsAfterTargetBuilt()
        {
            int[] target = { 1, 2 };
            int n = 4;

            var solution = new _1441_BuildanArrayWithStackOperations();

            IList<string> result = solution.BuildArray(target, n);

            CollectionAssert.AreEqual(
                new List<string> { "Push", "Push" },
                result.ToList());
        }

        [TestMethod]
        public void BuildArray_Target23_N3_ReturnsPopForMissingOne()
        {
            int[] target = { 2, 3 };
            int n = 3;

            var solution = new _1441_BuildanArrayWithStackOperations();

            IList<string> result = solution.BuildArray(target, n);

            CollectionAssert.AreEqual(
                new List<string>
                {
                "Push", "Pop",
                "Push",
                "Push"
                },
                result.ToList());
        }

        [TestMethod]
        public void BuildArray_Target14_N4_ReturnsPopForTwoAndThree()
        {
            int[] target = { 1, 4 };
            int n = 4;

            var solution = new _1441_BuildanArrayWithStackOperations();

            IList<string> result = solution.BuildArray(target, n);

            CollectionAssert.AreEqual(
                new List<string>
                {
                "Push",
                "Push", "Pop",
                "Push", "Pop",
                "Push"
                },
                result.ToList());
        }

        [TestMethod]
        public void BuildArray_SingleElementTarget_ReturnsPush()
        {
            int[] target = { 1 };
            int n = 1;

            var solution = new _1441_BuildanArrayWithStackOperations();

            IList<string> result = solution.BuildArray(target, n);

            CollectionAssert.AreEqual(
                new List<string> { "Push" },
                result.ToList());
        }

        [TestMethod]
        public void BuildArray_Target3_N3_ReturnsTwoPushPopThenPush()
        {
            int[] target = { 3 };
            int n = 3;

            var solution = new _1441_BuildanArrayWithStackOperations();

            IList<string> result = solution.BuildArray(target, n);

            CollectionAssert.AreEqual(
                new List<string>
                {
                "Push", "Pop",
                "Push", "Pop",
                "Push"
                },
                result.ToList());
        }
    }
}

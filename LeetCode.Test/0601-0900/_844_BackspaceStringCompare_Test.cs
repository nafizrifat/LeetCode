using LeetCode._0601_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0601_0900
{
    [TestClass]
    public class _844_BackspaceStringCompare_Test
    {
        [TestMethod]
        public void BackspaceCompare_BothBecomeSame_ReturnsTrue()
        {
            // "ab#c" -> "ac"
            // "ad#c" -> "ac"
            string s = "ab#c";
            string t = "ad#c";

            var solution = new _844_BackspaceStringCompare();

            bool result = solution.BackspaceCompare(s, t);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BackspaceCompare_MultipleBackspaces_BothBecomeSame_ReturnsTrue()
        {
            // "ab##" -> ""
            // "c#d#" -> ""
            string s = "ab##";
            string t = "c#d#";

            var solution = new _844_BackspaceStringCompare();

            bool result = solution.BackspaceCompare(s, t);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BackspaceCompare_BackspaceAtBeginning_BothBecomeSame_ReturnsTrue()
        {
            // "a#c" -> "c"
            // "b" -> "b"
            string s = "a#c";
            string t = "b";

            var solution = new _844_BackspaceStringCompare();

            bool result = solution.BackspaceCompare(s, t);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void BackspaceCompare_ExtraBackspaces_ReturnsTrue()
        {
            // "####a" -> "a"
            // "a" -> "a"
            string s = "####a";
            string t = "a";

            var solution = new _844_BackspaceStringCompare();

            bool result = solution.BackspaceCompare(s, t);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BackspaceCompare_OnlyBackspaces_ReturnsTrue()
        {
            // "###" -> ""
            // "##" -> ""
            string s = "###";
            string t = "##";

            var solution = new _844_BackspaceStringCompare();

            bool result = solution.BackspaceCompare(s, t);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BackspaceCompare_NoBackspacesSameStrings_ReturnsTrue()
        {
            string s = "abc";
            string t = "abc";

            var solution = new _844_BackspaceStringCompare();

            bool result = solution.BackspaceCompare(s, t);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BackspaceCompare_NoBackspacesDifferentStrings_ReturnsFalse()
        {
            string s = "abc";
            string t = "abd";

            var solution = new _844_BackspaceStringCompare();

            bool result = solution.BackspaceCompare(s, t);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void BackspaceCompare_BackspaceRemovesMultipleCharacters_ReturnsTrue()
        {
            // "xywrrmp" -> "xywrrmp"
            // "xywrrmu#p" -> "xywrrmp"
            string s = "xywrrmp";
            string t = "xywrrmu#p";

            var solution = new _844_BackspaceStringCompare();

            bool result = solution.BackspaceCompare(s, t);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BackspaceCompare_SameFinalLengthButDifferentCharacters_ReturnsFalse()
        {
            // "ab#c" -> "ac"
            // "ad#b" -> "ab"
            string s = "ab#c";
            string t = "ad#b";

            var solution = new _844_BackspaceStringCompare();

            bool result = solution.BackspaceCompare(s, t);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void BackspaceCompare_ComplexBackspaces_ReturnsTrue()
        {
            // "abc###d" -> "d"
            // "###d" -> "d"
            string s = "abc###d";
            string t = "###d";

            var solution = new _844_BackspaceStringCompare();

            bool result = solution.BackspaceCompare(s, t);

            Assert.IsTrue(result);
        }
    }
}

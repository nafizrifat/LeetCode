using LeetCode._0331_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0331_600
{
    [TestClass]
    public class _383_RansomNote_Test
    {
        [TestMethod]
        public void CanConstruct_WhenMagazineDoesNotContainCharacter_ReturnsFalse()
        {
            // Arrange
            _383_RansomNote solution = new _383_RansomNote();

            string ransomNote = "a";
            string magazine = "b";

            // Act
            bool result = solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanConstruct_WhenMagazineDoesNotHaveEnoughCharacters_ReturnsFalse()
        {
            // Arrange
            _383_RansomNote solution = new _383_RansomNote();

            string ransomNote = "aa";
            string magazine = "ab";

            // Act
            bool result = solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanConstruct_WhenMagazineHasEnoughCharacters_ReturnsTrue()
        {
            // Arrange
            _383_RansomNote solution = new _383_RansomNote();

            string ransomNote = "aa";
            string magazine = "aab";

            // Act
            bool result = solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsTrue(result);
        }
    }
}

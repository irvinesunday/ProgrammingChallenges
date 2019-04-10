using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingChallenges;

namespace ProgrammingChallengeTests
{
    [TestClass]
    public class BracketsValidationTests
    {
        [TestMethod]
        public void StringWithBothOpenAndClosedBracketsInOrder()
        {
            string sentence = "(if (taken? x) median (1 x))";

            bool result = BracketsValidation.IsStringValid(sentence, '(', ')');

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void StringWithOneClosedBracketMissingOpenBracket()
        {
            string sentence = "The )quick) brown fox jumped over the (blue) wall.";

            bool result = BracketsValidation.IsStringValid(sentence, '(', ')');

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void StringWithOneOpenBracketMissingClosedBracket()
        {
            string sentence = "The (quick) brown fox jumped over the (blue wall.";

            bool result = BracketsValidation.IsStringValid(sentence, '(', ')');

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void StringStartingWithClosedBracket()
        {
            string sentence = ") The quick brown ().";

            bool result = BracketsValidation.IsStringValid(sentence, '(', ')');

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void StringWithOneClosedBracket()
        {
            string sentence = ":-)";

            bool result = BracketsValidation.IsStringValid(sentence, '(', ')');

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void StringWithOneOpenBracket()
        {
            string sentence = "(-:";

            bool result = BracketsValidation.IsStringValid(sentence, '(', ')');

            Assert.IsFalse(result);
        }
    }
}

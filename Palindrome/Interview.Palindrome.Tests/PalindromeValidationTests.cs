using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview.Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Palindrome.Tests
{
    [TestClass]
    public class PalindromeValidationTests
    {
        IPalindromeValidation _validator = new PalindromeValidation();

        [TestMethod]
        public void ValidateTest_EvenPalindrome()
        {
            bool result = _validator.Validate("abccba");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateTest_PalindromeCaseInsensitive()
        {
            bool result = _validator.Validate("DABbAd");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateTest_OddPalindrome()
        {
            bool result = _validator.Validate("asdsa");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateTest_EvenNotPalindrome()
        {
            bool result = _validator.Validate("asddfa");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateTest_OddNotPalindrome()
        {
            bool result = _validator.Validate("asd");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateTest_TwoCharsPalindrome()
        {
            bool result = _validator.Validate("aa");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateTest_TwoCharsNotPalindrome()
        {
            bool result = _validator.Validate("ac");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateTest_EmptyString()
        {
            bool result = _validator.Validate(string.Empty);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateTest_OneCharString()
        {
            bool result = _validator.Validate("a");

            Assert.IsTrue(result);
        }
    }
}
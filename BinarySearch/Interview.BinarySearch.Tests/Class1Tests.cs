using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview.BinarySearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.BinarySearch.Tests
{
    [TestClass]
    public class Class1Tests
    {
        [TestMethod]
        public void BinarySearch_SearchForExistingElementOddLength()
        {
            Class1 c = new Class1(new int[] { 1, 3, 5, 7, 9, 11, 13 });

            int result = c.BinarySearch(5);

            Assert.AreEqual<int>(2, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForExistingElementEvenLength()
        {
            Class1 c = new Class1(new int[] { 1, 3, 5, 7, 9, 11 });

            int result = c.BinarySearch(9);

            Assert.AreEqual<int>(4, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForExistingElementInTwoElementsArray()
        {
            Class1 c = new Class1(new int[] { 1, 3 });

            int result = c.BinarySearch(3);

            Assert.AreEqual<int>(1, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForMaxElement()
        {
            Class1 c = new Class1(new int[] { 1, 3, 5, 7, 9, 11, 13 });

            int result = c.BinarySearch(13);

            Assert.AreEqual<int>(6, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForMinElement()
        {
            Class1 c = new Class1(new int[] { 1, 3, 5, 7, 9, 11, 13 });

            int result = c.BinarySearch(1);

            Assert.AreEqual<int>(0, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForExistingElementArrayWithEqualElements()
        {
            Class1 c = new Class1(new int[] { 1, 1, 1, 1, 1, 1 });

            int result = c.BinarySearch(1);

            Assert.AreEqual<int>(2, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForNonexistingValue()
        {
            Class1 c = new Class1(new int[] { 1, 3, 5, 7, 9, 11, 13 });

            int result = c.BinarySearch(15);

            Assert.AreEqual<int>(-1, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForExistingElementInOneElementArray()
        {
            Class1 c = new Class1(new int[] { 1 });

            int result = c.BinarySearch(1);

            Assert.AreEqual<int>(0, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForNonExistingElementInOneElementArray()
        {
            Class1 c = new Class1(new int[] { 1 });

            int result = c.BinarySearch(2);

            Assert.AreEqual<int>(-1, result);
        }

        [TestMethod]
        public void BinarySearch_SearchInEmptyArray()
        {
            Class1 c = new Class1(new int[] { });

            int result = c.BinarySearch(2);

            Assert.AreEqual<int>(-1, result);
        }
    }
}
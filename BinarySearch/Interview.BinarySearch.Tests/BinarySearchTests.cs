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
    public class BinarySearchTests
    {
        private enum SearchType
        {
            SimpleApproach
        }

        private static class SearchFactory
        {
            public static IBinarySearch CreateSearch(SearchType type, IEnumerable<int> values)
            {
                switch (type)
                {
                    case SearchType.SimpleApproach:
                        return new SimpleApproach(values);
                    default:
                        return null;
                }
            }
        }

        private const SearchType _typeToTest = SearchType.SimpleApproach;

        [TestMethod]
        public void BinarySearch_SearchForExistingElementOddLength()
        {
            IBinarySearch c = SearchFactory.CreateSearch(_typeToTest, new int[] { 1, 3, 5, 7, 9, 11, 13 });

            int result = c.BinarySearch(5);

            Assert.AreEqual<int>(2, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForExistingElementEvenLength()
        {
            IBinarySearch c = SearchFactory.CreateSearch(_typeToTest, new int[] { 1, 3, 5, 7, 9, 11 });

            int result = c.BinarySearch(9);

            Assert.AreEqual<int>(4, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForExistingElementInTwoElementsArray()
        {
            IBinarySearch c = SearchFactory.CreateSearch(_typeToTest, new int[] { 1, 3 });

            int result = c.BinarySearch(3);

            Assert.AreEqual<int>(1, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForNonExistingElementInTwoElementsArray()
        {
            IBinarySearch c = SearchFactory.CreateSearch(_typeToTest, new int[] { 7, 9 });

            int result = c.BinarySearch(8);

            Assert.AreEqual<int>(-1, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForMaxElement()
        {
            IBinarySearch c = SearchFactory.CreateSearch(_typeToTest, new int[] { 1, 3, 5, 7, 9, 11, 13 });

            int result = c.BinarySearch(13);

            Assert.AreEqual<int>(6, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForMinElement()
        {
            IBinarySearch c = SearchFactory.CreateSearch(_typeToTest, new int[] { 1, 3, 5, 7, 9, 11, 13 });

            int result = c.BinarySearch(1);

            Assert.AreEqual<int>(0, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForExistingElementArrayWithEqualElements()
        {
            IBinarySearch c = SearchFactory.CreateSearch(_typeToTest, new int[] { 1, 1, 1, 1, 1, 1 });

            int result = c.BinarySearch(1);

            Assert.AreEqual<int>(3, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForNonexistingValueBiggerThanMax()
        {
            IBinarySearch c = SearchFactory.CreateSearch(_typeToTest, new int[] { 1, 3, 5, 7, 9, 11, 13 });

            int result = c.BinarySearch(15);

            Assert.AreEqual<int>(-1, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForNonexistingValueSmallerThanMin()
        {
            IBinarySearch c = SearchFactory.CreateSearch(_typeToTest, new int[] { 1, 3, 5, 7, 9, 11, 13 });

            int result = c.BinarySearch(0);

            Assert.AreEqual<int>(-1, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForExistingElementInOneElementArray()
        {
            IBinarySearch c = SearchFactory.CreateSearch(_typeToTest, new int[] { 1 });

            int result = c.BinarySearch(1);

            Assert.AreEqual<int>(0, result);
        }

        [TestMethod]
        public void BinarySearch_SearchForNonExistingElementInOneElementArray()
        {
            IBinarySearch c = SearchFactory.CreateSearch(_typeToTest, new int[] { 1 });

            int result = c.BinarySearch(2);

            Assert.AreEqual<int>(-1, result);
        }

        [TestMethod]
        public void BinarySearch_SearchInEmptyArray()
        {
            IBinarySearch c = SearchFactory.CreateSearch(_typeToTest, new int[] { });

            int result = c.BinarySearch(2);

            Assert.AreEqual<int>(-1, result);
        }
    }
}
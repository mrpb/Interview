using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview.BinarySearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.BinarySearch.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void BinarySearch_ElementInside()
        {
            Class1 c = new Class1(new int[] { 1, 3, 5, 7, 9, 11, 13 });

            int result = c.BinarySearch(5);

            Assert.AreEqual<int>(2, result);
        }

        //todo: one element array, boundary element (first last), empty array, null, nonexisting element
    }
}
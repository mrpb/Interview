using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LinkedList.Tests
{
    [TestClass]
    public class CycleFinderTests
    {
        [TestMethod]
        public void HasCycleTest_NullList()
        {
            LinkedList<int> list = null;

            bool result = CycleFinder.HasCycle<int>(list);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasCycleTest_EmptyList()
        {
            LinkedList<int> list = new LinkedList<int>(null);

            bool result = CycleFinder.HasCycle<int>(list);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasCycleTest_OneElementList()
        {
            LinkedList<int> list = new LinkedList<int>(new int[] { 1 });

            bool result = CycleFinder.HasCycle<int>(list);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasCycleTest_TwoElementsList()
        {
            LinkedList<int> list = new LinkedList<int>(new int[] { 1, 2 });

            bool result = CycleFinder.HasCycle<int>(list);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasCycleTest_ListWithACycle()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void HasCycleTest_ListWithoutACycle()
        {
            Assert.Fail();
        }
    }
}
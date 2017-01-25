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
            LinkedList<int> list = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            LinkedListNode<int> middle = null;

            foreach (LinkedListNode<int> node in list)
            {
                if (node.NodeValue == 4)
                    middle = node;
                else if (node.Next == null)
                {
                    node.Next = middle;
                    break;
                }
            }

            bool result = CycleFinder.HasCycle<int>(list);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasCycleTest_ListWithoutACycle()
        {
            LinkedList<int> list = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            bool result = CycleFinder.HasCycle<int>(list);

            Assert.IsFalse(result);
        }
    }
}
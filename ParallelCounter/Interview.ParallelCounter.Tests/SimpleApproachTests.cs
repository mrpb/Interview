using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview.ParallelCounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Interview.ParallelCounter.Tests
{
    [TestClass]
    public class SimpleApproachTests
    {
        private const int iterations = 100000;

        [TestMethod]
        public void IncrementTest_CountersAreEqual()
        {
            ICounter counter = new CounterWithLock();

            using (CountdownEvent finish = new CountdownEvent(iterations))
            {
                for (int i = 0; i < iterations; i++)
                {
                    ThreadPool.QueueUserWorkItem(x =>
                                                    {
                                                        ((ICounter)x).Increment();
                                                        finish.Signal();
                                                    },
                                                counter);
                }

                finish.Wait();
            }

            Assert.AreEqual(iterations, counter.Value);
        }
    }
}
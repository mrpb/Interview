using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.ParallelCounter
{
    public class CounterWithLock : ICounter
    {
        public int Value { get; private set; }

        private readonly object _lock = new object();

        public void Increment()
        {
            lock(_lock)
            {
                Value += 1;
            }
        }
    }
}

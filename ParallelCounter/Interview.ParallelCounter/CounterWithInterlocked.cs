using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interview.ParallelCounter
{
    public class CounterWithInterlocked : ICounter
    {
        private int _value;

        public int Value
        {
            get { return _value; }
        }

        public void Increment()
        {
            Interlocked.Increment(ref _value);
        }
    }
}

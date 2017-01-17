using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.ParallelCounter
{
    public class Counter : ICounter
    {
        public int Value { get; private set; }

        public void Increment()
        {
            Value += 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.ParallelCounter
{
    public class SimpleApproach
    {
        public int Counter { get; private set; }

        public void Increment()
        {
            Counter += 1;
        }
    }
}

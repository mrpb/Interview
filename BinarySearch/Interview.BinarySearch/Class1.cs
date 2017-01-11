using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.BinarySearch
{
    public class Class1
    {
        private List<int> _list;

        public Class1(IEnumerable<int> values)
        {
            _list = new List<int>(values);
        }

        public int BinarySearch(int val)
        {
            int leftIdx = 0;
            int rightIdx = _list.Count - 1;

            while(leftIdx < rightIdx)
            {
                int midIdx = leftIdx + (int)((rightIdx - leftIdx) / 2);
                int midVal = _list[midIdx];

                if (midVal == val)
                    return midIdx;
                else if (val < midVal)
                    rightIdx = midIdx;
                else
                    leftIdx = midIdx;
            }

            return -1;
        }
    }
}

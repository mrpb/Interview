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
            int listLength = rightIdx - leftIdx + 1;

            if (listLength == 1 && _list[0] == val)
                return 0;

            while(leftIdx < rightIdx)
            {
                listLength = rightIdx - leftIdx + 1;

                if (listLength <= 2)
                {
                    if (_list[leftIdx] == val)
                        return leftIdx;
                    else if (_list[rightIdx] == val)
                        return rightIdx;
                    else
                        return -1;
                }

                int midIdx = leftIdx + (int)(listLength / 2);
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

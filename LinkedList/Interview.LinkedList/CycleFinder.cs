using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LinkedList
{
    public class CycleFinder
    {
        LinkedList<int> _list;

        public CycleFinder(IEnumerable<int> collection)
        {
            _list = new LinkedList<int>(collection);
        }

        public bool HasCycle()
        {
            foreach (var item in _list)
            {

            }

            return false;
        }
    }
}

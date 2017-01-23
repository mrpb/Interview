using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LinkedList
{
    public class CustomLinkedList<T> : IEnumerable<CustomLinkedListNode<T>>
    {
        CustomLinkedListNode<T> _head;

        public IEnumerator<CustomLinkedListNode<T>> GetEnumerator()
        {
            if (_head == null)
                return null;

            CustomLinkedListNode<T> 

            while()
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class CustomLinkedListNode<T>
    {
        public T NodeValue { get; set; }

        public CustomLinkedListNode<T> Previous { get; set; }

        public CustomLinkedListNode<T> Next { get; set; }
    }
}

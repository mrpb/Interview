using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LinkedList
{
    public class LinkedList<T> : IEnumerable<LinkedListNode<T>>
    {
        public LinkedList(IEnumerable<T> collection)
        {
            if (collection == null)
                return;

            LinkedListNode<T> tail = null;

            foreach (T val in collection)
            {
                if (Head == null)
                {
                    Head = new LinkedListNode<T>(val);
                    tail = Head;
                }
                else
                {
                    tail.Next = new LinkedListNode<T>(val);
                    tail = tail.Next;
                }
            }
        }

        public LinkedListNode<T> Head { get; private set; }

        public IEnumerator<LinkedListNode<T>> GetEnumerator()
        {
            if (Head == null)
                yield return null;

            LinkedListNode<T> currentNode = Head;

            while(currentNode != null)
            {
                yield return currentNode;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class LinkedListNode<T>
    {
        public LinkedListNode(T val)
        {
            NodeValue = val;
        }

        public T NodeValue { get; private set; }

        public LinkedListNode<T> Next { get; set; }
    }
}

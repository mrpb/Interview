using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LinkedList
{
    public class CycleFinder
    {
        public static bool HasCycle<T>(LinkedList<T> list)
        {
            if (list.Head == null || list.Head.Next == null)
                return false;

            LinkedListNode<T> turtle = list.Head;
            LinkedListNode<T> rabbit = list.Head.Next;

            while (turtle != rabbit)
            {
                if (rabbit.Next == null || rabbit.Next.Next == null)
                    return false;

                turtle = turtle.Next;
                rabbit = rabbit.Next.Next;
            }

            return true;
        }
    }
}

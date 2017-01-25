using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.SumTreeNodes
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }
    }

    public class TreeNode<T>
    {
        public TreeNode(T nodeValue)
        {
            NodeValue = nodeValue;
        }

        public TreeNode(T nodeValue, IEnumerable<T> values)
        {
            List<TreeNode<T>> list = null;

            if (values != null && values.Count() > 0)
            {
                list = new List<TreeNode<T>>();

                foreach (T val in values)
                {
                    list.Add(new TreeNode<T>(val));
                }
            }

            NodeValue = nodeValue;
            Neighbors = list;
        }

        public T NodeValue { get; private set; }

        public IEnumerable<TreeNode<T>> Neighbors { get; private set; }
    }
}

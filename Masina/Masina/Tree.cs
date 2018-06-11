using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masina
{
    public class Tree<TElem> : IEnumerable where TElem : IComparable
    {
        class Node
        {
            public int Size { get; set; }
            public TElem elem;
            public Node left = null, right = null;
            public Node(TElem value)
            {
                elem = value;
                Size = 1;
            }
        }

        private Node root = null;

        private void AddBalance(Node x, TElem value)
        {
            if (value.CompareTo(x.elem) < 0)
            {
                if (x.left == null)
                {
                    x.left = new Node(value);
                    return;
                }
                AddBalance(x.left, value);
            }
            else
            {
                if (x.right == null)
                {
                    x.right = new Node(value);
                    return;
                }
                AddBalance(x.right, value);
            }
        }

        private Node GetNext(Node x)
        {
            if (x.left == null)
                return x.right;
            return x.left;
        }

        private void Remove(TElem value)
        {
            Node x = root, lastX = null;
            while (x != null)
            {
                if (value.CompareTo(x.elem) < 0)
                    x = x.left;
                else if (value.CompareTo(x.elem) > 0)
                    x = x.right;
                else
                {
                    if (lastX == null)
                    {
                        root = GetNext(x);
                        return;
                    }
                    if (lastX.left == x)
                    {
                        lastX.left = GetNext(x);
                        return;
                    }
                    else
                    {
                        lastX.right = GetNext(x);
                        return;
                    }
                }
                lastX = x;
            }
            return;
        }

        public void Add(TElem value)
        {
            if (root == null)
            {
                root = new Node(value);
                return;
            }
            AddBalance(root, value);
        }
        public Tree()
        {

        }

    private void GetList(List<TElem> l, Node x)
        {
            if (x == null)
                return;
            GetList(l, x.left);
            l.Add(x.elem);
            GetList(l, x.right);
        }

    public IEnumerator GetEnumerator()
        {
            List<TElem> l = new List<TElem>();
            GetList(l, root);
            foreach (var it in l)
            {
                yield return it;
            }
        }
    }
}

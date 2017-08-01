using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Tree<T> : ITree<T>
    {
        private T value;
        private ITree<T> left;
        private ITree<T> right;

        internal Tree(T value)
        {
            this.value = value;
        }

        public T Value => value;

        public ITree<T> Left
        {
            get => left;
            internal set
            {
                if (left != null)
                {
                    throw new InvalidOperationException("The left subtree is already assigned");
                }

                left = value;
            }
        }

        public ITree<T> Right
        {
            get => right;
            internal set
            {
                if (right != null)
                {
                    throw new InvalidOperationException("The right subtree is already assigned");
                }
                right = value;
            }
        }

        public bool IsLeaf => left == null && right == null;
    }
}

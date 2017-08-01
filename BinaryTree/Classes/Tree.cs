using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// A binary tree.
    /// </summary>
    /// <typeparam name="T">A type of a node or leaf value</typeparam>
    public class Tree<T> where T : IComparable<T>
    {
        private T value;
        private Tree<T> left;
        private Tree<T> right;

        internal Tree(T value)
        {
            this.value = value;
        }

        /// <summary>
        /// A value of the node
        /// </summary>
        public T Value => value;

        /// <summary>
        /// Left subtree
        /// </summary>
        public Tree<T> Left
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

        /// <summary>
        /// Right subtree
        /// </summary>
        public Tree<T> Right
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

        /// <summary>
        /// Returns true if this node is a leaf
        /// </summary>
        public bool IsLeaf => left == null && right == null;

        /// <summary>
        /// Returns true if this tree is a binary search tree
        /// </summary>
        internal bool IsSearch
        {
            get
            {
                return (left == null || left.Value.CompareTo(Value) == -1 && left.IsSearch) &&
                    (right == null || right.Value.CompareTo(Value) == 1 && right.IsSearch);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// A binary tree.
    /// </summary>
    /// <typeparam name="T">A type of a node or leaf value</typeparam>
    public class Tree<T> : ISerializable where T : IComparable<T>
    {
        private T value;
        private Tree<T> left;
        private Tree<T> right;

        internal Tree(T value)
        {
            this.value = Helpers.Check(value, nameof(value));
        }

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

        internal Tree(SerializationInfo info, StreamingContext ctxt)
        {
            this.value = (T)info.GetValue("value", typeof(T));
            this.left = (Tree<T>)info.GetValue("left", typeof(Tree<T>));
            this.right = (Tree<T>)info.GetValue("right", typeof(Tree<T>));
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("value", value, typeof(T));
            info.AddValue("left", left, typeof(Tree<T>));
            info.AddValue("right", right, typeof(Tree<T>));
        }
    }
}

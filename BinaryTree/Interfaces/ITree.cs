using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// An interface defining a binary tree.
    /// </summary>
    /// <typeparam name="T">A type of a node or leaf value</typeparam>
    public interface ITree<T>
    {
        /// <summary>
        /// A value of the node
        /// </summary>
        T Value { get; }

        /// <summary>
        /// Left subtree
        /// </summary>
        ITree<T> Left { get; }

        /// <summary>
        /// Right subtree
        /// </summary>
        ITree<T> Right { get; }

        /// <summary>
        /// Returns true if this node is a leaf
        /// </summary>
        bool IsLeaf { get; }
    }
}

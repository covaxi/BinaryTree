using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Interfaces
{
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

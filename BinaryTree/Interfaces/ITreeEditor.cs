using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// An interface for creating or modifying a binary tree
    /// <typeparamref name="T">A type of a tree node value</typeparamref>
    /// </summary>
    public interface ITreeEditor<T>
    {
        /// <summary>
        /// Creates a tree with a single node
        /// </summary>
        /// <param name="value">Value for the node</param>
        /// <param name="operation">An operation to perform on a node</param>
        /// <returns></returns>
        ITree<T> Create(T value, Action<ITree<T>> operation = null);

        /// <summary>
        /// Appends a node to a tree. Throws an IncorrectOperation exception if a parent tree already has a node on the selected position.
        /// </summary>
        /// <param name="parent">A parent tree</param>
        /// <param name="position">A position for adding a child node, Left or Right</param>
        /// <param name="value">Value for the child node</param>
        /// <param name="operation">An operation to perform on an added node</param>
        /// <returns>A tree with added child node</returns>
        ITree<T> Append(ITree<T> parent, Position position, T value, Action<ITree<T>> operation = null);

        /// <summary>
        /// Removes a whole subtree of a parent node on a selected position.
        /// </summary>
        /// <param name="parent">A parent node</param>
        /// <param name="position">Position of a subtree to remove</param>
        /// <returns></returns>
        ITree<T> Remove(ITree<T> parent, Position position);
    }
}
